#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 09/25/2017 13:00:22
//	   Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.ViewModel.Struct;
using ResourceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using Utilities;

namespace DANMIS_NEW.ViewModel
{
    public class UserBaseModel
    {
        public UserBaseModel()
        {
            IsEnable = true;
        }

        #region == DB Fields ==

        /// <summary>
        /// SequenceNo
        /// </summary>
        public int SequenceNo { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UserName", ResourceType = typeof(Resource))]
        public string Name { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [Remote("AccountBeUse", "User", AdditionalFields = "Initial", ErrorMessageResourceName = "BeUsedError", ErrorMessageResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(256, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Account", ResourceType = typeof(Resource))]
        public string Account { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [DataType(DataType.Password)]
        [StringLength(128, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        [RegularExpression("^(?=.*[A-Z])(?=.*[!@#$&\\-_*])(?=.*[0-9])(?=.*[a-z]).{8,12}$", ErrorMessageResourceName = "PasswordError", ErrorMessageResourceType = typeof(Resource))]
        public string Password { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [DataType(DataType.EmailAddress, ErrorMessageResourceName = "EmailError", ErrorMessageResourceType = typeof(Resource))]
        [EmailAddress(ErrorMessageResourceName = "EmailError", ErrorMessageResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(256, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        public string Email { get; set; }

        /// <summary>
        /// ContactTel
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(20, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ContactTel", ResourceType = typeof(Resource))]
        public string ContactTel { get; set; }

        /// <summary>
        /// IsEnable
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "IsEnable", ResourceType = typeof(Resource))]
        public bool IsEnable { get; set; }

        /// <summary>
        /// CreateUser
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CreateUser", ResourceType = typeof(Resource))]
        public string CreateUser { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        [Display(Name = "CreateTime", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// UpdateUser
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UpdateUser", ResourceType = typeof(Resource))]
        public string UpdateUser { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        [Display(Name = "UpdateTime", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// LoginTime
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "LoginTime", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// ChnagePassTime
        /// </summary>
        [Display(Name = "ChangePassTime", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ChangePassTime { get; set; }

        /// <summary>
        /// PhotoPath
        /// </summary>
        [StringLength(256, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "PhotoPath", ResourceType = typeof(Resource))]
        public string PhotoPath { get; set; }

        /// <summary>
        /// HashToken
        /// </summary>
        [StringLength(256, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "HashToken", ResourceType = typeof(Resource))]
        public string HashToken { get; set; }

        /// <summary>
        /// FreeFields
        /// </summary>
        public TemplateFields FreeFields { get; set; }

        /// <summary>
        /// DefaultIndex
        /// </summary>
        [Display(Name = "DefaultIndex", ResourceType = typeof(Resource))]
        public Nullable<Guid> DefaultIndex { get; set; }

        /// <summary>
        /// DepartmentID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Department", ResourceType = typeof(Resource))]
        public Nullable<Guid> DepartmentID { get; set; }

        /// <summary>
        /// DepartmentIDs
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Department", ResourceType = typeof(Resource))]
        public List<Guid> DepartmentIDs { get; set; }

        /// <summary>
        /// EmpUniqNo
        /// </summary>        
        [Display(Name = "EmpUniqNo", ResourceType = typeof(Resource))]
        public int EmpUniqNo { get; set; }

        /// <summary>
        /// EmpEngName
        /// </summary>        
        [Display(Name = "EmpEngName", ResourceType = typeof(Resource))]
        public string EmpEngName { get; set; }

        /// <summary>
        /// RegionCode
        /// </summary>        
        [Display(Name = "RegionCode", ResourceType = typeof(Resource))]
        public string RegionCode { get; set; }

        /// <summary>
        /// CompCode
        /// </summary>        
        [Display(Name = "CompCode", ResourceType = typeof(Resource))]
        public string CompCode { get; set; }

        /// <summary>
        /// OfficeCode
        /// </summary>        
        [Display(Name = "OfficeCode", ResourceType = typeof(Resource))]
        public string OfficeCode { get; set; }

        /// <summary>
        /// DeptCode
        /// </summary>        
        [Display(Name = "DeptCode", ResourceType = typeof(Resource))]
        public string DeptCode { get; set; }

        /// <summary>
        /// EmpNo
        /// </summary>        
        [Display(Name = "EmpNo", ResourceType = typeof(Resource))]
        public string EmpNo { get; set; }

        /// <summary>
        /// EmpEngOfficialName
        /// </summary>        
        [Display(Name = "EmpEngOfficialName", ResourceType = typeof(Resource))]
        public string EmpEngOfficialName { get; set; }

        /// <summary>
        /// EmpLocName
        /// </summary>        
        [Display(Name = "EmpLocName", ResourceType = typeof(Resource))]
        public string EmpLocName { get; set; }

        /// <summary>
        /// EmpGender
        /// </summary>        
        [Display(Name = "EmpGender", ResourceType = typeof(Resource))]
        public string EmpGender { get; set; }

        /// <summary>
        /// JobTitleCode
        /// </summary>        
        [Display(Name = "JobTitleCode", ResourceType = typeof(Resource))]
        public string JobTitleCode { get; set; }

        /// <summary>
        /// EmpStartDate
        /// </summary>        
        [Display(Name = "EmpStartDate", ResourceType = typeof(Resource))]
        public DateTime EmpStartDate { get; set; }

        /// <summary>
        /// EmpQuitDate
        /// </summary>        
        [Display(Name = "EmpQuitDate", ResourceType = typeof(Resource))]
        public DateTime EmpQuitDate { get; set; }


        /// <summary>
        /// EmpStatusCode
        /// </summary>        
        [Display(Name = "EmpStatusCode", ResourceType = typeof(Resource))]
        public string EmpStatusCode { get; set; }


        /// <summary>
        /// JobStatusCode
        /// </summary>        
        [Display(Name = "JobStatusCode", ResourceType = typeof(Resource))]
        public string JobStatusCode { get; set; }

        /// <summary>
        /// EmpCompEmail
        /// </summary>        
        [Display(Name = "EmpCompEmail", ResourceType = typeof(Resource))]
        public string EmpCompEmail { get; set; }

        /// <summary>
        /// EmpADLoginID
        /// </summary>        
        [Display(Name = "EmpADLoginID", ResourceType = typeof(Resource))]
        public string EmpADLoginID { get; set; }

        /// <summary>
        /// EmpComputerID
        /// </summary>        
        [Display(Name = "EmpComputerID", ResourceType = typeof(Resource))]
        public string EmpComputerID { get; set; }

        /// <summary>
        /// EmpPrivateEMail
        /// </summary>        
        [Display(Name = "EmpPrivateEMail", ResourceType = typeof(Resource))]
        public string EmpPrivateEMail { get; set; }

        /// <summary>
        /// EmpHomePhone
        /// </summary>        
        [Display(Name = "EmpHomePhone", ResourceType = typeof(Resource))]
        public string EmpHomePhone { get; set; }

        /// <summary>
        /// EmpMobilePhone
        /// </summary>        
        [Display(Name = "EmpMobilePhone", ResourceType = typeof(Resource))]
        public string EmpMobilePhone { get; set; }

        /// <summary>
        /// BossEmpUniqNo
        /// </summary>        
        [Display(Name = "BossEmpUniqNo", ResourceType = typeof(Resource))]
        public int BossEmpUniqNo { get; set; }

        /// <summary>
        /// EmpAcctStatus
        /// </summary>        
        [Display(Name = "EmpAcctStatus", ResourceType = typeof(Resource))]
        public string EmpAcctStatus { get; set; }

        /// <summary>
        /// WritingLanguage
        /// </summary>        
        [Display(Name = "WritingLanguage", ResourceType = typeof(Resource))]
        public string WritingLanguage { get; set; }

        /// <summary>
        /// SysLanguage
        /// </summary>        
        [Display(Name = "SysLanguage", ResourceType = typeof(Resource))]
        public string SysLanguage { get; set; }

        /// <summary>
        /// EmpBankAccount
        /// </summary>        
        [Display(Name = "EmpBankAccount", ResourceType = typeof(Resource))]
        public string EmpBankAccount { get; set; }

        /// <summary>
        /// EmpPhoto
        /// </summary>        
        [Display(Name = "EmpPhoto", ResourceType = typeof(Resource))]
        public string EmpPhoto { get; set; }

        /// <summary>
        /// CheckAttendance
        /// </summary>        
        [Display(Name = "CheckAttendance", ResourceType = typeof(Resource))]
        public string CheckAttendance { get; set; }

        /// <summary>
        /// ExtDisplayFlag
        /// </summary>        
        [Display(Name = "ExtDisplayFlag", ResourceType = typeof(Resource))]
        public string ExtDisplayFlag { get; set; }

        /// <summary>
        /// SpcInTime
        /// </summary>        
        [Display(Name = "SpcInTime", ResourceType = typeof(Resource))]
        public string SpcInTime { get; set; }

        /// <summary>
        /// SpcOutTime
        /// </summary>        
        [Display(Name = "SpcOutTime", ResourceType = typeof(Resource))]
        public string SpcOutTime { get; set; }

        /// <summary>
        /// InputBy
        /// </summary>        
        [Display(Name = "InputBy", ResourceType = typeof(Resource))]
        public int InputBy { get; set; }

        /// <summary>
        /// InputDate
        /// </summary>        
        [Display(Name = "InputDate", ResourceType = typeof(Resource))]
        public DateTime InputDate { get; set; }

        /// <summary>
        /// ChangeBe
        /// </summary>        
        [Display(Name = "ChangeBe", ResourceType = typeof(Resource))]
        public int ChangeBe { get; set; }

        /// <summary>
        /// ChangeDate
        /// </summary>        
        [Display(Name = "ChangeDate", ResourceType = typeof(Resource))]
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Random
        /// </summary>        
        [Display(Name = "Random", ResourceType = typeof(Resource))]
        public string Random { get; set; }

        /// <summary>
        /// NextBossEmpUniqNo
        /// </summary>        
        [Display(Name = "NextBossEmpUniqNo", ResourceType = typeof(Resource))]
        public int NextBossEmpUniqNo { get; set; }

        /// <summary>
        /// Do_PDP
        /// </summary>        
        [Display(Name = "Do_PDP", ResourceType = typeof(Resource))]
        public string Do_PDP { get; set; }

        /// <summary>
        /// EmpExtNo
        /// </summary>        
        [Display(Name = "EmpExtNo", ResourceType = typeof(Resource))]
        public string EmpExtNo { get; set; }

        /// <summary>
        /// WDID
        /// </summary>        
        [Display(Name = "WDID", ResourceType = typeof(Resource))]
        public string WDID { get; set; }

        /// <summary>
        /// TaxiAccount
        /// </summary>        
        [Display(Name = "TaxiAccount", ResourceType = typeof(Resource))]
        public string TaxiAccount { get; set; }

        /// <summary>
        /// BrandCode
        /// </summary>        
        [Display(Name = "BrandCode", ResourceType = typeof(Resource))]
        public string BrandCode { get; set; }

        /// <summary>
        /// EmpType
        /// </summary>        
        [Display(Name = "EmpType", ResourceType = typeof(Resource))]
        public string EmpType { get; set; }

        /// <summary>
        /// CostCenter
        /// </summary>        
        [Display(Name = "CostCenter", ResourceType = typeof(Resource))]
        public string CostCenter { get; set; }

        /// <summary>
        /// ProfitCenter
        /// </summary>        
        [Display(Name = "ProfitCenter", ResourceType = typeof(Resource))]
        public string ProfitCenter { get; set; }

        /// <summary>
        /// LastWorkDate
        /// </summary>        
        [Display(Name = "LastWorkDate", ResourceType = typeof(Resource))]
        public DateTime LastWorkDate { get; set; }

        /// <summary>
        /// CardNo
        /// </summary>        
        [Display(Name = "CardNo", ResourceType = typeof(Resource))]
        public string CardNo { get; set; }

        /// <summary>
        /// FloorNo
        /// </summary>        
        [Display(Name = "FloorNo", ResourceType = typeof(Resource))]
        public string FloorNo { get; set; }

        /// <summary>
        /// SeatNo
        /// </summary>        
        [Display(Name = "SeatNo", ResourceType = typeof(Resource))]
        public string SeatNo { get; set; }

        /// <summary>
        /// MotoNo
        /// </summary>        
        [Display(Name = "MotoNo", ResourceType = typeof(Resource))]
        public string MotoNo { get; set; }

        /// <summary>
        /// MotocycleID
        /// </summary>        
        [Display(Name = "MotocycleID", ResourceType = typeof(Resource))]
        public string MotocycleID { get; set; }

        /// <summary>
        /// ETag
        /// </summary>        
        [Display(Name = "ETag", ResourceType = typeof(Resource))]
        public string ETag { get; set; }

        /// <summary>
        /// MotoStartDate
        /// </summary>        
        [Display(Name = "MotoStartDate", ResourceType = typeof(Resource))]
        public DateTime MotoStartDate { get; set; }

        /// <summary>
        /// FaxNo
        /// </summary>        
        [Display(Name = "FaxNo", ResourceType = typeof(Resource))]
        public string FaxNo { get; set; }

        /// <summary>
        /// LeaseLine
        /// </summary>        
        [Display(Name = "LeaseLine", ResourceType = typeof(Resource))]
        public string LeaseLine { get; set; }

        /// <summary>
        /// AssestNo
        /// </summary>        
        [Display(Name = "AssestNo", ResourceType = typeof(Resource))]
        public string AssestNo { get; set; }

        /// <summary>
        /// ThirdCode
        /// </summary>        
        [Display(Name = "ThirdCode", ResourceType = typeof(Resource))]
        public string ThirdCode { get; set; }

        #endregion == DB Fields ==
    }

    public class UserViewModel : UserBaseModel
    {
        #region == View Fields ==

        /// <summary>
        /// 使用者擁有的功能清單
        /// </summary>
        public List<Auth> Auth { get; set; }

        /// <summary>
        /// 功能下拉
        /// </summary>
        public SelectList FunctionList { get; set; }

        /// <summary>
        /// 圖示上傳物件
        /// </summary>
        [Display(Name = "UploadPhoto", ResourceType = typeof(Resource))]
        public HttpPostedFileBase PhotoUpload { get; set; }

        /// <summary>
        /// 使用者擁有的角色
        /// </summary>
        [Display(Name = "Role", ResourceType = typeof(Resource))]
        public List<Guid> RoleID { get; set; }

        /// <summary>
        /// 角色下拉
        /// </summary>
        public SelectList RoleList { get; set; }

        /// <summary>
        /// 部門下拉
        /// </summary>
        public SelectList DepartmentList { get; set; }

        /// <summary>
        /// 跑馬燈
        /// </summary>
        public List<string> Marquee { get; set; }

        #endregion == View Fields ==
    }
}
#pragma warning restore 1591