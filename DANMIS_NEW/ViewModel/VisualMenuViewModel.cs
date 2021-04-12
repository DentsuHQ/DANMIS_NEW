#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 09/01/2020 11:32:35
//	   Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using ResourceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace DANMIS_NEW.ViewModel
{
    public class VisualMenuBaseModel
    {
        public VisualMenuBaseModel()
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
        /// ParentID
        /// </summary>
        [Display(Name = "MenuParent", ResourceType = typeof(Resource))]
        public Nullable<Guid> ParentID { get; set; }

        /// <summary>
        /// Sequence
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Sequence", ResourceType = typeof(Resource))]
        [Range(byte.MinValue, byte.MaxValue, ErrorMessageResourceName = "RangeError", ErrorMessageResourceType = typeof(Resource))]
        public byte Sequence { get; set; }

        /// <summary>
        /// MenuLevel
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "MenuLevel", ResourceType = typeof(Resource))]
        [Range(byte.MinValue, byte.MaxValue, ErrorMessageResourceName = "RangeError", ErrorMessageResourceType = typeof(Resource))]
        public byte MenuLevel { get; set; }

        /// <summary>
        /// MenuCode
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(20, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "MenuCode", ResourceType = typeof(Resource))]
        public string MenuCode { get; set; }

        /// <summary>
        /// MenuName
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "MenuName", ResourceType = typeof(Resource))]
        public string MenuName { get; set; }

        /// <summary>
        /// Layout
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(20, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Layout", ResourceType = typeof(Resource))]
        public string Layout { get; set; }

        /// <summary>
        /// IconPath
        /// </summary>
        [StringLength(128, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "IconPath", ResourceType = typeof(Resource))]
        public string IconPath { get; set; }

        /// <summary>
        /// HeaderPath
        /// </summary>
        [StringLength(128, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "HeaderPath", ResourceType = typeof(Resource))]
        public string HeaderPath { get; set; }

        /// <summary>
        /// ViewCount
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ViewCount", ResourceType = typeof(Resource))]
        public int ViewCount { get; set; }

        /// <summary>
        /// Controller
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Controller", ResourceType = typeof(Resource))]
        public string Controller { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Action", ResourceType = typeof(Resource))]
        public string Action { get; set; }

        /// <summary>
        /// Parameter
        /// </summary>
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Parameter", ResourceType = typeof(Resource))]
        public string Parameter { get; set; }

        /// <summary>
        /// ExternalUrl
        /// </summary>
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ExternalUrl", ResourceType = typeof(Resource))]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// IsInlinePage
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "IsInlinePage", ResourceType = typeof(Resource))]
        public bool IsInlinePage { get; set; }

        /// <summary>
        /// IsShowFooter
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "IsShowFooter", ResourceType = typeof(Resource))]
        public bool IsShowFooter { get; set; }

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

        #endregion == DB Fields ==
    }

    public class VisualMenuViewModel : VisualMenuBaseModel
    {
        #region == View Fields ==

        /// <summary>
        /// 功能選單
        /// </summary>
        public SelectList MenuList { get; set; }

        /// <summary>
        /// 圖示上傳物件
        /// </summary>
        [Display(Name = "UploadIcon", ResourceType = typeof(Resource))]
        public HttpPostedFileBase IconUpload { get; set; }

        /// <summary>
        /// 版型上傳物件
        /// </summary>
        [Display(Name = "UploadHeader", ResourceType = typeof(Resource))]
        public HttpPostedFileBase HeaderUpload { get; set; }

        #endregion == View Fields ==
    }
}
#pragma warning restore 1591