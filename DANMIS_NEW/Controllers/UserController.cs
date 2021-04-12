#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 10/12/2017 15:20:20
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.Interface;
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.ListResult;
using DANMIS_NEW.ViewModel.SearchModel;
using NLog;
using ResourceLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Utilities;
using Utilities.Attribute;
using Utilities.Utility;

namespace DANMIS_NEW.Controllers
{
    public class UserController : BaseController
    {
        public const string uploadPath = "~/Content/Uploads/User/";

        readonly ICommonManager _commonManager;
        readonly IUserManager _userManager;

        public UserController(
            ICommonManager commonManager,
            IUserManager userManager)
        {
            _commonManager = commonManager;
            _userManager = userManager;
            logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// 檢查 Account 是否重複
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Initial"></param>
        /// <returns></returns>
        [WebAuthorize(Code = "UserCreate,UserEdit")]
        [HttpGet]
        public ActionResult AccountBeUse(string Account, string Initial)
        {
            bool result = false;
            if (Account.Trim().ToLower() != Initial.Trim().ToLower())
            {
                try
                {
                    result = _userManager.AccountBeUse(Account);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, string.Format(Resource.CheckBeUsedError, Resource.User, Resource.Account));

                    // 檢查發生錯誤，當作名稱重複，不給儲存。
                    result = true;
                }
            }

            return Json(!result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Index()
        {
            // 初始化查詢物件
            var searchModel = new UserSearchModel();
            if (null != UnobtrusiveSession.Session["QueryModel"])
            {
                // 查詢條件存在 session 則取出
                var temp = UnobtrusiveSession.Session["QueryModel"] as UserSearchModel;
                if (null != temp)
                {
                    searchModel = temp;
                }
            }
            // 初始化查詢下拉選單
            searchModel.YesNoList = _commonManager.GetYesNoList();

            return View(searchModel);
        }

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        [WebAuthorize(Code = "UserIndex")]
        [HttpPost]
        public ActionResult Paging(UserSearchModel searchModel)
        {
            // 查詢條件儲存於 session
            UnobtrusiveSession.Session["QueryModel"] = searchModel;
            // 查詢結果物件初始化
            var result = new Paging<UserListResult> { total = 0, rows = null };
            // 查詢
            try
            {
                result = _userManager.Paging(searchModel);
            }
            catch (Exception ex)
            {
                logger.Error(ex, string.Format(Resource.PagingError, Resource.User));
            }

            return Json(result);
        }

        /// <summary>
        /// 取得 Role List
        /// </summary>
        /// <param name="orgId"></param>
        /// <returns></returns>
        [WebAuthorize(Code = "Pass")]
        [HttpPost]
        public ActionResult GetRoleList()
        {
            var result = _commonManager.GetRoleList();

            return Json(result);
        }

        /// <summary>
        /// 取得 Function List
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        [WebAuthorize(Code = "Pass")]
        [HttpPost]
        public ActionResult GetFunctionList(List<Guid> roles)
        {
            var result = _commonManager.GetFunctionList(roles);

            return Json(result);
        }

        /// <summary>
        /// 檢視 User 頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Details(Guid? id)
        {
            UserViewModel viewModel = null;
            if (id.HasValue && id.Value != Guid.Empty)
            {
                try
                {
                    // 讀取資料
                    viewModel = _userManager.GetByID(id.Value);
                    if (null == viewModel)
                    {
                        // 查無資料
                        logger.Error(string.Format(Resource.NoData, Resource.User, id.Value));
                        TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.NoData, Resource.User, id.Value) }.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // 查詢發生錯誤
                    logger.Error(ex, string.Format(Resource.GetDetailsDataError, Resource.User, id.Value));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.GetDetailsDataError, Resource.User, id.Value) }.ToString();
                }
            }
            else
            {
                // 參數錯誤
                logger.Error(string.Format(Resource.ParamError, Resource.Details));
                TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ParamError, Resource.Details) }.ToString();
            }
            // 查無資料轉回列表頁
            if (null == viewModel)
            {
                return RedirectToAction("Index");
            }
            // 初始化檢視頁面下拉選單
            setDropDownList(ref viewModel);

            return View(viewModel);
        }

        /// <summary>
        /// 新增 User 頁面
        /// </summary>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new UserViewModel();
            // 初始化編輯頁面下拉選單
            setDropDownList(ref viewModel);

            return View(viewModel);
        }

        /// <summary>
        /// 新增資料儲存
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpPost]
        public ActionResult Create(UserViewModel viewModel)
        {
            //強制加入密碼為必填
            if (string.IsNullOrEmpty(viewModel.Password))
                ModelState.AddModelError("Password", string.Format(Resource.RequiredError, Resource.Password));

            // 驗證
            if (ModelState.IsValid)
            {
                try
                {
                    viewModel.ID = Guid.NewGuid();
                    viewModel.CreateUser = UserName;
                    viewModel.CreateTime = NowTime;
                    viewModel.UpdateUser = UserName;
                    viewModel.UpdateTime = NowTime;
                    viewModel.LoginTime = NowTime;
                    viewModel.ChangePassTime = NowTime;
                    if (uploadImage(this, viewModel.PhotoUpload, uploadPath, viewModel.ID.ToString(), out string result, out int width, out int height))
                        viewModel.PhotoPath = result;
                    _userManager.Create(viewModel);
                    UnobtrusiveSession.Session["QueryModel"] = null;
                    // 完成
                    TempData["ErrorMsg"] = new JsonMessage { Style = "success", Message = string.Format(Resource.ExecutionCompleted, Resource.Create, Resource.User) }.ToString();
                    // 轉回列表頁
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // 儲存發生錯誤
                    logger.Error(ex, string.Format(Resource.ExecutionFailedWithID, Resource.Create, Resource.User, viewModel.ID));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ExecutionFailedWithID, Resource.Create, Resource.User, viewModel.ID) }.ToString();
                }
            }
            // 初始化新增頁面下拉選單
            setDropDownList(ref viewModel);

            return View(viewModel);
        }

        /// <summary>
        /// 修改 User 頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Edit(Guid? id)
        {
            UserViewModel viewModel = null;
            if (id.HasValue && id.Value != Guid.Empty)
            {
                try
                {
                    // 讀取資料
                    viewModel = _userManager.GetByID(id.Value);
                    if (null == viewModel)
                    {
                        // 查無資料
                        logger.Error(string.Format(Resource.NoData, Resource.User, id.Value));
                        TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.NoData, Resource.User, id.Value) }.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // 查詢發生錯誤
                    logger.Error(ex, string.Format(Resource.GetEditDataError, Resource.User, id.Value));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.GetEditDataError, Resource.User, id.Value) }.ToString();
                }
            }
            else
            {
                // 參數錯誤
                logger.Error(string.Format(Resource.ParamError, Resource.Edit));
                TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ParamError, Resource.Edit) }.ToString();
            }
            // 查無資料轉回列表頁
            if (null == viewModel)
            {
                return RedirectToAction("Index");
            }
            // 初始化編輯頁面下拉選單
            viewModel.Password = string.Empty;
            setDropDownList(ref viewModel);

            return View("Create", viewModel);
        }

        /// <summary>
        /// 編輯資料儲存
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpPost]
        public ActionResult Edit(UserViewModel viewModel)
        {
            ModelState.Remove("Account");

            // 驗證
            if (ModelState.IsValid)
            {
                try
                {
                    viewModel.UpdateUser = UserName;
                    viewModel.UpdateTime = NowTime;
                    if (uploadImage(this, viewModel.PhotoUpload, uploadPath, viewModel.ID.ToString(), out string result, out int width, out int height))
                        viewModel.PhotoPath = result;
                    _userManager.Update(viewModel);
                    // 完成
                    TempData["ErrorMsg"] = new JsonMessage { Style = "success", Message = string.Format(Resource.ExecutionCompleted, Resource.Edit, Resource.User) }.ToString();
                    // 轉回列表頁
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // 儲存發生錯誤
                    logger.Error(ex, string.Format(Resource.ExecutionFailedWithID, Resource.Edit, Resource.User, viewModel.ID));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ExecutionFailedWithID, Resource.Edit, Resource.User, viewModel.ID) }.ToString();
                }
            }
            // 初始化編輯頁面下拉選單
            setDropDownList(ref viewModel);

            return View("Create", viewModel);
        }

        /// <summary>
        /// 刪除機構資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpPost]
        public ActionResult Delete(List<Guid> id)
        {
            // 預設失敗
            var result = false;
            // id 有值進行刪除作業
            if (id != null && id.Any())
            {
                try
                {
                    // 進行刪除
                    _userManager.Delete(id);
                    result = true;
                }
                catch (Exception ex)
                {
                    // 刪除失敗
                    logger.Error(ex, string.Format(Resource.ExecutionFailed, Resource.Delete, Resource.User, id));
                }
            }

            return Json(result);
        }

        /// <summary>
        /// 設定頁面所需要的下拉選單資料
        /// </summary>
        /// <param name="viewModel"></param>
        void setDropDownList(ref UserViewModel viewModel)
        {
            viewModel.FunctionList = _commonManager.GetFunctionList(viewModel.RoleID);
            viewModel.RoleList = _commonManager.GetRoleList();
            viewModel.DepartmentList = _commonManager.GetDepartmentList();
        }
    }
}
#pragma warning restore 1591