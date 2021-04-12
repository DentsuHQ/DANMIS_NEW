#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 03/15/2021 18:35:12
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
using System.Web.Mvc;

namespace DANMIS_NEW.ViewModel
{
    public class NonChargeableBaseModel
    {
        public NonChargeableBaseModel()
        {
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
        /// WORK_CARD_NO
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(150, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "WORK_CARD_NO", ResourceType = typeof(Resource))]
        public string WORK_CARD_NO { get; set; }

        /// <summary>
        /// ProjectName
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(150, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ProjectName", ResourceType = typeof(Resource))]
        public string ProjectName { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "StartDate", ResourceType = typeof(Resource))]
        public string StartDate { get; set; }

        /// <summary>
        /// CompleteDate
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CompleteDate", ResourceType = typeof(Resource))]
        public string CompleteDate { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(150, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }

        /// <summary>
        /// ProjectStatus
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ProjectStatus", ResourceType = typeof(Resource))]
        public string ProjectStatus { get; set; }

        /// <summary>
        /// ProjectOwnerID
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ProjectOwnerID", ResourceType = typeof(Resource))]
        public string ProjectOwnerID { get; set; }

        /// <summary>
        /// OwnerEmail
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "OwnerEmail", ResourceType = typeof(Resource))]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// PortfolioName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "PortfolioName", ResourceType = typeof(Resource))]
        public string PortfolioName { get; set; }

        /// <summary>
        /// PortfolioOwnerID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "PortfolioOwnerID", ResourceType = typeof(Resource))]
        public string PortfolioOwnerID { get; set; }

        /// <summary>
        /// ProgramName
        /// </summary>
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ProgramName", ResourceType = typeof(Resource))]
        public string ProgramName { get; set; }

        /// <summary>
        /// ProgramOwnerID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ProgramOwnerID", ResourceType = typeof(Resource))]
        public string ProgramOwnerID { get; set; }

        /// <summary>
        /// CurrencyINR
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CurrencyINR", ResourceType = typeof(Resource))]
        public string CurrencyINR { get; set; }

        /// <summary>
        /// Budget
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Budget", ResourceType = typeof(Resource))]
        public string Budget { get; set; }

        /// <summary>
        /// Benefit
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Benefit", ResourceType = typeof(Resource))]
        public string Benefit { get; set; }

        /// <summary>
        /// ClientName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ClientName", ResourceType = typeof(Resource))]
        public string ClientName { get; set; }

        /// <summary>
        /// LineofBusiness
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "LineofBusiness", ResourceType = typeof(Resource))]
        public string LineofBusiness { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Region", ResourceType = typeof(Resource))]
        public string Region { get; set; }

        /// <summary>
        /// BrandName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "BrandName", ResourceType = typeof(Resource))]
        public string BrandName { get; set; }

        /// <summary>
        /// Market
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Market", ResourceType = typeof(Resource))]
        public string Market { get; set; }

        /// <summary>
        /// Office
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Office", ResourceType = typeof(Resource))]
        public string Office { get; set; }

        /// <summary>
        /// Chargeable
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Chargeable", ResourceType = typeof(Resource))]
        public string Chargeable { get; set; }

        /// <summary>
        /// Commission
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "Commission", ResourceType = typeof(Resource))]
        public string Commission { get; set; }

        /// <summary>
        /// GroupName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "GroupName", ResourceType = typeof(Resource))]
        public string GroupName { get; set; }

        /// <summary>
        /// AccProjID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "AccProjID", ResourceType = typeof(Resource))]
        public string AccProjID { get; set; }

        /// <summary>
        /// LegalEntity
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "LegalEntity", ResourceType = typeof(Resource))]
        public string LegalEntity { get; set; }

        /// <summary>
        /// FinSourSys
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "FinSourSys", ResourceType = typeof(Resource))]
        public string FinSourSys { get; set; }

        /// <summary>
        /// CRMURNID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CRMURNID", ResourceType = typeof(Resource))]
        public string CRMURNID { get; set; }

        /// <summary>
        /// CRMSourSys
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CRMSourSys", ResourceType = typeof(Resource))]
        public string CRMSourSys { get; set; }

        /// <summary>
        /// OtherSource
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "OtherSource", ResourceType = typeof(Resource))]
        public string OtherSource { get; set; }

        /// <summary>
        /// AdditionalProjectID
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "AdditionalProjectID", ResourceType = typeof(Resource))]
        public string AdditionalProjectID { get; set; }

        /// <summary>
        /// RecordStatus
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "RecordStatus", ResourceType = typeof(Resource))]
        public string RecordStatus { get; set; }

        /// <summary>
        /// ImportDate
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ImportDate", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ImportDate { get; set; }

        /// <summary>
        /// UploadDate
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UploadDate", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UploadDate { get; set; }

        /// <summary>
        /// ImportUniqNo
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ImportUniqNo", ResourceType = typeof(Resource))]
        public int ImportUniqNo { get; set; }

        /// <summary>
        /// ImportLocName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ImportLocName", ResourceType = typeof(Resource))]
        public string ImportLocName { get; set; }

        /// <summary>
        /// ImportEngName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "ImportEngName", ResourceType = typeof(Resource))]
        public string ImportEngName { get; set; }

        /// <summary>
        /// UploadUniqNo
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UploadUniqNo", ResourceType = typeof(Resource))]
        public int UploadUniqNo { get; set; }

        /// <summary>
        /// UploadLocName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UploadLocName", ResourceType = typeof(Resource))]
        public string UploadLocName { get; set; }

        /// <summary>
        /// UploadEngName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "UploadEngName", ResourceType = typeof(Resource))]
        public string UploadEngName { get; set; }

        /// <summary>
        /// CompareDate
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CompareDate", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CompareDate { get; set; }

        /// <summary>
        /// CompareUniqNo
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CompareUniqNo", ResourceType = typeof(Resource))]
        public int CompareUniqNo { get; set; }

        /// <summary>
        /// CompareLocName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CompareLocName", ResourceType = typeof(Resource))]
        public string CompareLocName { get; set; }

        /// <summary>
        /// CompareEngName
        /// </summary>
        //[Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(Resource))]
        [StringLength(50, ErrorMessageResourceName = "StringLengthError", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "CompareEngName", ResourceType = typeof(Resource))]
        public string CompareEngName { get; set; }

        /// <summary>
        /// ImportType
        /// </summary>                
        public string ImportType { get; set; }

        /// <summary>
        /// ProjectID
        /// </summary>                
        public string ProjectID { get; set; }

        /// <summary>
        /// MediaType
        /// </summary>                
        public string MediaType { get; set; }

        /// <summary>
        /// ProjectType
        /// </summary>                
        public string ProjectType { get; set; }
        #endregion == DB Fields ==
    }

    public class NonChargeableViewModel : NonChargeableBaseModel
    {
        #region == View Fields ==
        public SelectList BrandList { get; set; }
        public SelectList MediaTypeList { get; set; }
        public SelectList ProjectStatusList { get; set; }
        public SelectList ProjectTypeList { get; set; }
        public SelectList ChargeableList { get; set; }
        #endregion == View Fields ==
    }
}
#pragma warning restore 1591