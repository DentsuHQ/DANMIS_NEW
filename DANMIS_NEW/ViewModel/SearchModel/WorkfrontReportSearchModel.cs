#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 03/04/2021 15:25:33
//     Runtime Version: 4.0.30319.42000
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

namespace DANMIS_NEW.ViewModel.SearchModel
{
    public class WorkfrontReportSearchModel : PostedFileBaseModel
    {
        public WorkfrontReportSearchModel()
        {
            Search = string.Empty;
            Sort = "SequenceNo";
            Order = "desc";
            Limit = 10;
            Offset = 0;
        }

        [Display(Name = "Keyword", ResourceType = typeof(Resource))]
        public string Search { get; set; }

        public string Sort { get; set; }

        public string Order { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public Dictionary<string, SelectList> Formatter { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "IsChargeable", ResourceType = typeof(Resource))]
        public string IsChargeable { get; set; }
        public SelectList _IsChargeable { get; set; }

        [Display(Name = "ProjectStatus", ResourceType = typeof(Resource))]
        public string Status { get; set; }
        public SelectList _Status { get; set; }

        [Display(Name = "ProjectType", ResourceType = typeof(Resource))]
        public string ProjectType { get; set; }
        public SelectList _ProjectType { get; set; }
    }
}
#pragma warning restore 1591