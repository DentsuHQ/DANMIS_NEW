#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/12/2021 14:42:56
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using ResourceLibrary;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DANMIS_NEW.ViewModel.SearchModel
{
    public class FactorySearchModel : SearchModel
    {
        [Display(Name = "FactoryClass", ResourceType = typeof(Resource))]
        public string FactoryClass { get; set; }
        public SelectList _FactoryClass { get; set; }
    }
}
#pragma warning restore 1591