#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/16/2021 12:12:49
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NLog;
using ResourceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Utilities;
using Utilities.Attribute;
using Utilities.Utility;
using DANMIS_NEW.Interface;
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.ListResult;
using DANMIS_NEW.ViewModel.SearchModel;

namespace DANMIS_NEW.Controllers
{
    public class VotesController : BaseController
    {
        readonly ICommonManager _commonManager;
        readonly IVotesManager _votesManager;
        readonly ICandidateManager _candidateManager;
        readonly IVoterManager _voterManager;
        readonly IBrandManager _brandManager;
        readonly IUserManager _userManager;        

        public VotesController(
            ICommonManager commonManager,
            IVotesManager votesManager,
            ICandidateManager candidateManager,
            IVoterManager voterManager,
            IBrandManager brandManager,
            IUserManager userManager)
        {
            _commonManager = commonManager;
            _votesManager = votesManager;
            _candidateManager = candidateManager;
            _voterManager = voterManager;
            _brandManager = brandManager;
            _userManager = userManager;
            logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Index()
        {
            var bSearchModel = new BrandSearchModel();
            var brands = _brandManager.Paging(bSearchModel).rows.ToList();
            
            // 初始化查詢物件
            var searchModel = new VotesSearchModel();
            searchModel.BrandList = _brandManager.GetSelectList();

            if (null != UnobtrusiveSession.Session["QueryModel"])
            {
                // 查詢條件存在 session 則取出
                var temp = UnobtrusiveSession.Session["QueryModel"] as VotesSearchModel;
                if (null != temp)
                {
                    searchModel = temp;
                }
            }

            searchModel.StartDate = Convert.ToDateTime("2021-04-17");
            searchModel.EndDate = Convert.ToDateTime("2021-04-30");


            var _compCode = brands.FirstOrDefault(x => x.BrandID == CompCode)?.BrandCode ?? string.Empty;
            searchModel.CanVote = false;
            if (!string.IsNullOrEmpty(_compCode))
            {
                var cSearchModel = new CandidateSearchModel();
                // 依登入者取得可投票人(不包含自己)
                cSearchModel.CompCode = _compCode;
                cSearchModel.WDID = WDID;
                var pagingCandidates = _candidateManager.Paging(cSearchModel);
                var candidates = pagingCandidates.rows;
                foreach (var item in candidates)
                {
                    item.Company = brands.FirstOrDefault(x => x.BrandCode == item.Company.Split(' ')[0]).BrandID;
                }
                searchModel.Candidates = candidates;
                
                var _canVote = false;
                var _hasVote = false;

                // 判斷投票人名單是否有自己
                var hasVote = _voterManager.GetByWDID(WDID);
                if (!string.IsNullOrEmpty(hasVote.EmployeeID))
                    _canVote = true;

                // 判斷是否已投過
                var isVote = _votesManager.GetByWDID(WDID);
                if (!string.IsNullOrEmpty(isVote.EmployeeID))
                {
                    _hasVote = true;
                    // show訊息
                    searchModel.ShowMsg = "您已投過票囉!";
                }

                if (_canVote == true && _hasVote == false)
                    searchModel.CanVote = true;
                else
                {
                    searchModel.CanVote = false;
                    searchModel.WDID = isVote.VoteTo;
                }

                // 判斷可投票日期
                if (Today < searchModel.StartDate || Today > searchModel.EndDate)
                {
                    searchModel.CanVote = false;
                    searchModel.ShowMsg = "投票已結束!";
                }
            }

            return View(searchModel);
        }

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        [WebAuthorize(Code = "VotesIndex")]
        [HttpPost]
        public ActionResult Paging(VotesSearchModel searchModel)
        {
            var bSearchModel = new BrandSearchModel();
            var brands = _brandManager.Paging(bSearchModel).rows.ToList();
            var _compCode = brands.FirstOrDefault(x => x.BrandID == CompCode).BrandCode;
            var result = Json(new { result = true, message = "投票失敗!" }, JsonRequestBehavior.AllowGet);
            // 查詢
            try
            {
                if (!string.IsNullOrEmpty(searchModel.WDID) && searchModel.CanVote)
                {
                    var create = new VotesViewModel()
                    {
                        ID = Guid.NewGuid(),
                        EmployeeID = WDID,
                        FirstName = string.Empty,
                        LastName = string.Empty,
                        PreferredName = string.Empty,
                        Company = _compCode,
                        VoteTo = searchModel.WDID,
                        VoteDate = DateTime.Now,
                    };
                    _votesManager.Create(create);
                    result = Json(new { result = true, message = "投票成功!" }, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, string.Format(Resource.PagingError, Resource.Votes));
            }

            return result;
        }

        /// <summary>
        /// 檢視 Votes 頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Details(Guid? id)
        {
            VotesViewModel viewModel = null;
            if (id.HasValue && id.Value != Guid.Empty)
            {
                try
                {
                    // 讀取資料
                    viewModel = _votesManager.GetByID(id.Value);
                    if (null == viewModel)
                    {
                        // 查無資料
                        logger.Error(string.Format(Resource.NoData, Resource.Votes, id.Value));
                        TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.NoData, Resource.Votes, id.Value) }.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // 查詢發生錯誤
                    logger.Error(ex, string.Format(Resource.GetDetailsDataError, Resource.Votes, id.Value));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.GetDetailsDataError, Resource.Votes, id.Value) }.ToString();
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
        /// 新增 Votes 頁面
        /// </summary>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new VotesViewModel();
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
        public ActionResult Create(VotesViewModel viewModel)
        {
            // 驗證
            if (ModelState.IsValid)
            {
                try
                {
                    viewModel.ID = Guid.NewGuid();
                    _votesManager.Create(viewModel);
                    UnobtrusiveSession.Session["QueryModel"] = null;
                    // 完成
                    TempData["ErrorMsg"] = new JsonMessage { Style = "success", Message = string.Format(Resource.ExecutionCompleted, Resource.Create, Resource.Votes) }.ToString();
                    // 轉回列表頁
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // 儲存發生錯誤
                    logger.Error(ex, string.Format(Resource.ExecutionFailedWithID, Resource.Create, Resource.Votes, viewModel.ID));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ExecutionFailedWithID, Resource.Create, Resource.Votes, viewModel.ID) }.ToString();
                }
            }
            // 初始化新增頁面下拉選單
            setDropDownList(ref viewModel);

            return View(viewModel);
        }

        /// <summary>
        /// 修改 Votes 頁面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebAuthorize]
        [HttpGet]
        public ActionResult Edit(Guid? id)
        {
            VotesViewModel viewModel = null;
            if (id.HasValue && id.Value != Guid.Empty)
            {
                try
                {
                    // 讀取資料
                    viewModel = _votesManager.GetByID(id.Value);
                    if (null == viewModel)
                    {
                        // 查無資料
                        logger.Error(string.Format(Resource.NoData, Resource.Votes, id.Value));
                        TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.NoData, Resource.Votes, id.Value) }.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // 查詢發生錯誤
                    logger.Error(ex, string.Format(Resource.GetEditDataError, Resource.Votes, id.Value));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.GetEditDataError, Resource.Votes, id.Value) }.ToString();
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
        public ActionResult Edit(VotesViewModel viewModel)
        {
            // 驗證
            if (ModelState.IsValid)
            {
                try
                {
                    _votesManager.Update(viewModel);
                    // 完成
                    TempData["ErrorMsg"] = new JsonMessage { Style = "success", Message = string.Format(Resource.ExecutionCompleted, Resource.Edit, Resource.Votes) }.ToString();
                    // 轉回列表頁
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // 儲存發生錯誤
                    logger.Error(ex, string.Format(Resource.ExecutionFailedWithID, Resource.Edit, Resource.Votes, viewModel.ID));
                    TempData["ErrorMsg"] = new JsonMessage { Style = "danger", Message = string.Format(Resource.ExecutionFailedWithID, Resource.Edit, Resource.Votes, viewModel.ID) }.ToString();
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
                    _votesManager.Delete(id);
                    result = true;
                }
                catch (Exception ex)
                {
                    // 刪除失敗
                    logger.Error(ex, string.Format(Resource.ExecutionFailed, Resource.Delete, Resource.Votes, id));
                }
            }

            return Json(result);
        }

        /// <summary>
        /// 設定頁面所需要的下拉選單資料
        /// </summary>
        /// <param name="viewModel"></param>
        void setDropDownList(ref VotesViewModel viewModel)
        {
        }

        [HttpGet]
        public ActionResult GetStatistic()
        {
            var result = new JsonResult();
            
            var model = new StatisticModel();
            var statistics = new List<StatisticModel>();
            var votes = _votesManager.GetAll();
            
            var groupVotes = votes.GroupBy(x => new
            {
                VoteTo = x.VoteTo,
                Brand = x.Company
            }).Select(y => new Statistics
            {
                Candidate = y.Key.VoteTo,
                Brand = y.Key.Brand,
                Count = y.Count()
            }).ToList();

            foreach (var item in groupVotes)
            {
                var userDetail = _userManager.GetByWDID(item.Candidate);
                if (userDetail != null)
                {
                    var statisticModel = new StatisticModel
                    {
                        Brand = item.Brand,
                        Name = userDetail.Name,
                        Count = item.Count,
                    };
                    if (!string.IsNullOrEmpty(statisticModel.Name))
                        statistics.Add(statisticModel);
                }
            }

            result = Json(new { total = statistics.Count, rows = statistics }, JsonRequestBehavior.AllowGet);
            return result;
        }

        public class Statistics
        {
            public string Candidate { get; set; }
            public string Brand { get; set; }
            public int Count { get; set; }
        }

        public class StatisticModel
        {
            public string Brand { get; set; }
            public string Name { get; set; }
            public int Count { get; set; }            
        }

        [HttpGet]
        public ActionResult UserToRole()
        {
            var result = new JsonResult();
            
            var users = _userManager.GetAll().ToList();

            foreach (var item in users)
            {
                var voters = _voterManager.GetByWDID(item.WDID);
                if (!string.IsNullOrEmpty(voters.EmployeeID))
                {
                    item.DefaultIndex = new Guid("4C14D23E-B445-4AF7-BA54-FCA5A515AEDB");
                    item.RoleID.Add(new Guid("C1DC25C1-7950-4D08-9A9F-CD8FB1ABB4DD"));
                    _userManager.Update(item);
                }
            }

            result = Json(new { result = "寫入成功" }, JsonRequestBehavior.AllowGet);

            return result;
        }
    }
}
#pragma warning restore 1591