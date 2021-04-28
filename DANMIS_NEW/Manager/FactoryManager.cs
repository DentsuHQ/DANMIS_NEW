#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/12/2021 14:41:47
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
using System.Web;

namespace DANMIS_NEW.Manager
{
    public class FactoryManager : IFactoryManager
    {
        readonly IFactoryRepository _factoryRepository;
        readonly IFactoryClassRepository _factoryClassRepository;

        public FactoryManager(IFactoryRepository factoryRepository, IFactoryClassRepository factoryClassRepository)
        {
            _factoryRepository = factoryRepository;
            _factoryClassRepository = factoryClassRepository;
        }

        /// <summary>
        /// 建立 Factory
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Create(FactoryViewModel entity)
        {
            var item = (Factory)entity;

            using (var transaction = _factoryRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    _factoryRepository.Create(item);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 根據 id 刪除 Factory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete(List<Guid> id)
        {
            using (var transaction = _factoryRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var itemSet = _factoryRepository.Where(x => id.Contains(x.ID)).ToList();
                    if (itemSet.Any())
                    {
                        foreach (var item in itemSet)
                        {
                            _factoryRepository.Delete(item);
                        }
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 根據 id 取得 Factory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FactoryViewModel GetByID(Guid id)
        {
            var item = _factoryRepository.GetByID(id);
            var result = (FactoryViewModel)item;

            return result;
        }

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public Paging<FactoryListResult> Paging(FactorySearchModel searchModel)
        {
            // 預設集合
            var temp = _factoryRepository.GetAll();

            // 將 DB 資料轉換為列表頁呈現資料
            var tempResult = from x in temp
                             select new FactoryListResult
                             {
                                 SequenceNo = x.SequenceNo,
                                 ID = x.ID,
                                 FactoryName = x.FactoryName,
                                 FactoryShortName = x.FactoryShortName,
                                 IDNO = x.IDNO,
                                 TEL = x.TEL,
                                 FAX = x.FAX,
                                 Address = x.Address,
                                 FactoryClass = x.FactoryClass,
                                 IsShow = x.IsShow,
                                 Memo = x.Memo,                                
                                 UpdateUser = x.UpdateUser,
                                 UpdateTime = x.UpdateTime,
                                 ContactPerson = string.Empty,
                             };

            // 如有篩選條件，進行篩選
            if (!string.IsNullOrWhiteSpace(searchModel.Search))
            {
                var search = searchModel.Search.ToLower();
                tempResult = tempResult.Where(x =>
                    x.FactoryName.Contains(search) ||
                    x.FactoryShortName.Contains(search) ||
                    x.IDNO.Contains(search) ||
                    x.TEL.Contains(search) ||
                    x.FAX.Contains(search) ||
                    x.Address.Contains(search) ||
                    x.FactoryClass.Contains(search) ||
                    x.Memo.Contains(search) ||
                    x.UpdateUser.Contains(search) ||
                    false);
            }

            if(!string.IsNullOrEmpty(searchModel.FactoryClass))
                tempResult = tempResult.Where(x =>
                    x.FactoryClass == searchModel.FactoryClass ||
                    false);

            // 進行分頁處理
            var result = new Paging<FactoryListResult>();
            result.total = tempResult.Count();
            result.rows = tempResult
                .OrderBy(searchModel.Sort, searchModel.Order)
                .Skip(searchModel.Offset)
                .Take(searchModel.Limit)
                .ToList();

            foreach (var item in result.rows)
            {
                item.FactoryClass = switchFactoryClassName(new Guid(item.FactoryClass));
            }

            return result;
        }

        /// <summary>
        /// 更新 Factory
        /// </summary>
        /// <param name="entity"></param>
        public void Update(FactoryViewModel entity)
        {
            using (var transaction = _factoryRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var source = _factoryRepository.GetByID(entity.ID);
                    source.FactoryName = entity.FactoryName ?? string.Empty;
                    source.FactoryShortName = entity.FactoryShortName ?? string.Empty;
                    source.IDNO = entity.IDNO ?? string.Empty;
                    source.TEL = entity.TEL ?? string.Empty;
                    source.FAX = entity.FAX ?? string.Empty;
                    source.Address = entity.Address ?? string.Empty;
                    source.FactoryClass = entity.FactoryClass ?? string.Empty;
                    source.IsShow = entity.IsShow;
                    source.Memo = entity.Memo ?? string.Empty;
                    source.UpdateUser = entity.UpdateUser ?? string.Empty;
                    source.UpdateTime = entity.UpdateTime;

                    _factoryRepository.Update(source);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        #region switchFactoryClassName
        public string switchFactoryClassName(Guid factoryClass)
        {
            var result = _factoryClassRepository.GetByID(factoryClass).ClassName;
            return result;
        }
        #endregion

    }
}
#pragma warning restore 1591