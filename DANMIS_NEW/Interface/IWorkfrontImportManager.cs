#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 03/04/2021 15:24:21
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.ListResult;
using DANMIS_NEW.ViewModel.SearchModel;

namespace DANMIS_NEW.Interface
{
    public interface IWorkfrontImportManager : IManager
    {
        /// <summary>
        /// 建立 WorkfrontImport
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Create(WorkfrontImportViewModel entity);

        /// <summary>
        /// 根據 id 刪除 WorkfrontImport
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(List<Guid> id);

        /// <summary>
        /// 根據 id 取得 WorkfrontImport
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        WorkfrontImportViewModel GetByID(Guid id);

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        Paging<WorkfrontImportListResult> Paging(WorkfrontImportSearchModel searchModel);

        /// <summary>
        /// 更新 WorkfrontImport
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(WorkfrontImportViewModel entity);
    }
}
#pragma warning restore 1591