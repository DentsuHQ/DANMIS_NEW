#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 09/01/2020 11:32:04
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Extensions;
using DANMIS_NEW.Interface;
using DANMIS_NEW.Models;
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.ListResult;
using DANMIS_NEW.ViewModel.SearchModel;
using ResourceLibrary;
using DANMIS_NEW;

namespace DANMIS_NEW.Manager
{
    public class VisualMenuManager : IVisualMenuManager
    {
        readonly IVisualMenuRepository _visualMenuRepository;

        public VisualMenuManager(IVisualMenuRepository visualMenuRepository)
        {
            _visualMenuRepository = visualMenuRepository;
        }

        /// <summary>
        /// 建立 VisualMenu
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Create(VisualMenuViewModel entity)
        {
            var item = (VisualMenu)entity;

            using (var transaction = _visualMenuRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    _visualMenuRepository.Create(item);
                    transaction.Commit();
                    //更新快取資料
                    Global.UpdateEntity("Menu", item);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 根據 id 刪除 VisualMenu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete(List<Guid> id)
        {
            using (var transaction = _visualMenuRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var itemSet = _visualMenuRepository.Where(x => id.Contains(x.ID)).ToList();
                    if (itemSet.Any())
                    {
                        foreach (var item in itemSet)
                        {
                            _visualMenuRepository.Delete(item);
                        }
                    }
                    transaction.Commit();
                    //更新快取資料
                    Global.UpdateEntity("Menu", null, id);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 根據 id 取得 VisualMenu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VisualMenuViewModel GetByID(Guid id)
        {
            var item = _visualMenuRepository.GetByID(id);
            var result = (VisualMenuViewModel)item;

            return result;
        }

        /// <summary>
        /// 取得目前最大的順序序號
        /// </summary>
        /// <returns></returns>
        public byte GetSequence()
        {
            byte result = 0;
            if (_visualMenuRepository.Any())
            {
                result = _visualMenuRepository.GetAll().Max(x => x.Sequence);
            }

            return ++result;
        }

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public Paging<VisualMenuListResult> Paging(VisualMenuSearchModel searchModel)
        {
            // 預設集合
            var temp = _visualMenuRepository.GetAll();

            if (searchModel.IsEnable.HasValue)
            {
                temp = temp.Where(x => x.IsEnable == searchModel.IsEnable.Value);
            }

            // 將 DB 資料轉換為列表頁呈現資料
            var tempResult = from x in temp
                             select new VisualMenuListResult
                             {
                                 SequenceNo = x.SequenceNo,
                                 ID = x.ID,
                                 ParentID = x.ParentID,
                                 ParentName = x.Parent.MenuName,
                                 Sequence = x.Sequence,
                                 MenuLevel = x.MenuLevel,
                                 MenuCode = x.MenuCode,
                                 MenuName = x.MenuName,
                                 Layout = x.Layout,
                                 IconPath = x.IconPath,
                                 HeaderPath = x.HeaderPath,
                                 ViewCount = x.ViewCount,
                                 Controller = x.Controller,
                                 Action = x.Action,
                                 Parameter = x.Parameter,
                                 ExternalUrl = x.ExternalUrl,
                                 IsInlinePage = x.IsInlinePage,
                                 IsShowFooter = x.IsShowFooter,
                                 IsEnable = x.IsEnable,
                                 UpdateUser = x.UpdateUser,
                                 UpdateTime = x.UpdateTime,
                             };

            // 如有篩選條件，進行篩選
            if (!string.IsNullOrWhiteSpace(searchModel.Search))
            {
                var search = searchModel.Search.ToLower();
                tempResult = tempResult.Where(x =>
                    x.MenuCode.Contains(search) ||
                    x.MenuName.Contains(search) ||
                    false);
            }

            // 進行分頁處理
            var result = new Paging<VisualMenuListResult>();
            result.total = tempResult.Count();
            result.rows = tempResult
                .OrderBy(searchModel.Sort, searchModel.Order)
                .Skip(searchModel.Offset)
                .Take(searchModel.Limit)
                .ToList();

            return result;
        }

        /// <summary>
        /// 更新 VisualMenu
        /// </summary>
        /// <param name="entity"></param>
        public void Update(VisualMenuViewModel entity)
        {
            using (var transaction = _visualMenuRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var source = _visualMenuRepository.GetByID(entity.ID);
                    source.ParentID = entity.ParentID;
                    source.Sequence = entity.Sequence;
                    source.MenuLevel = entity.MenuLevel;
                    source.MenuCode = entity.MenuCode ?? string.Empty;
                    source.MenuName = entity.MenuName ?? string.Empty;
                    source.Layout = entity.Layout ?? string.Empty;
                    source.IconPath = entity.IconPath ?? string.Empty;
                    source.HeaderPath = entity.HeaderPath ?? string.Empty;
                    source.ViewCount = entity.ViewCount;
                    source.Controller = entity.Controller ?? string.Empty;
                    source.Action = entity.Action ?? string.Empty;
                    source.Parameter = entity.Parameter ?? string.Empty;
                    source.ExternalUrl = entity.ExternalUrl ?? string.Empty;
                    source.IsInlinePage = entity.IsInlinePage;
                    source.IsShowFooter = entity.IsShowFooter;
                    source.IsEnable = entity.IsEnable;
                    source.UpdateUser = entity.UpdateUser ?? string.Empty;
                    source.UpdateTime = entity.UpdateTime;

                    _visualMenuRepository.Update(source);
                    transaction.Commit();
                    //更新快取資料
                    Global.UpdateEntity("Menu", source);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
#pragma warning restore 1591