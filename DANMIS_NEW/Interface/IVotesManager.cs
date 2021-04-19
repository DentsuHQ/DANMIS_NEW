#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/16/2021 12:12:59
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
    public interface IVotesManager : IManager
    {
        /// <summary>
        /// 建立 Votes
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Create(VotesViewModel entity);

        /// <summary>
        /// 根據 id 刪除 Votes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(List<Guid> id);

        /// <summary>
        /// 根據 id 取得 Votes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        VotesViewModel GetByID(Guid id);

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        Paging<VotesListResult> Paging(VotesSearchModel searchModel);

        /// <summary>
        /// 更新 Votes
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(VotesViewModel entity);

        VotesViewModel GetByWDID(string id);

        List<VotesViewModel> GetAll();
    }
}
#pragma warning restore 1591