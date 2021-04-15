#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/15/2021 18:55:09
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

namespace DANMIS_NEW.Manager
{
    public class CompanyManager : ICompanyManager
    {
        readonly ICompanyRepository _companyRepository;

        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        /// <summary>
        /// 建立 Company
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Create(CompanyViewModel entity)
        {
            var item = (Company)entity;

            using (var transaction = _companyRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    _companyRepository.Create(item);
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
        /// 根據 id 刪除 Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete(List<Guid> id)
        {
            using (var transaction = _companyRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var itemSet = _companyRepository.Where(x => id.Contains(x.ID)).ToList();
                    if (itemSet.Any())
                    {
                        foreach (var item in itemSet)
                        {
                            _companyRepository.Delete(item);
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
        /// 根據 id 取得 Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CompanyViewModel GetByID(Guid id)
        {
            var item = _companyRepository.GetByID(id);
            var result = (CompanyViewModel)item;

            return result;
        }

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public Paging<CompanyListResult> Paging(CompanySearchModel searchModel)
        {
            // 預設集合
            var temp = _companyRepository.GetAll();

            // 將 DB 資料轉換為列表頁呈現資料
            var tempResult = from x in temp
                             select new CompanyListResult
                             {
                                 SequenceNo = x.SequenceNo,
                                 ID = x.ID,
                                 RegionCode = x.RegionCode,
                                 CompCode = x.CompCode,
                                 CompEngShortTitle = x.CompEngShortTitle,
                                 CompEngFullTitle = x.CompEngFullTitle,
                                 CompLocShortTitle = x.CompLocShortTitle,
                                 CompLocFullTitle = x.CompLocFullTitle,
                                 GUINo = x.GUINo,
                                 TelNo = x.TelNo,
                                 FaxNo = x.FaxNo,
                                 Address = x.Address,
                                 UpdateUser = x.UpdateUser,
                                 UpdateTime = x.UpdateTime,
                             };

            // 如有篩選條件，進行篩選
            if (!string.IsNullOrWhiteSpace(searchModel.Search))
            {
                var search = searchModel.Search.ToLower();
                tempResult = tempResult.Where(x =>
                    x.RegionCode.Contains(search) ||
                    x.CompCode.Contains(search) ||
                    x.CompEngShortTitle.Contains(search) ||
                    x.CompEngFullTitle.Contains(search) ||
                    x.CompLocShortTitle.Contains(search) ||
                    x.CompLocFullTitle.Contains(search) ||
                    x.GUINo.Contains(search) ||
                    x.TelNo.Contains(search) ||
                    x.FaxNo.Contains(search) ||
                    x.Address.Contains(search) ||
                    x.UpdateUser.Contains(search) ||
                    false);
            }

            // 進行分頁處理
            var result = new Paging<CompanyListResult>();
            result.total = tempResult.Count();
            result.rows = tempResult
                .OrderBy(searchModel.Sort, searchModel.Order)
                .Skip(searchModel.Offset)
                .Take(searchModel.Limit)
                .ToList();

            return result;
        }

        /// <summary>
        /// 更新 Company
        /// </summary>
        /// <param name="entity"></param>
        public void Update(CompanyViewModel entity)
        {
            using (var transaction = _companyRepository.dbContext.Database.BeginTransaction())
            {
                try
                {
                    var source = _companyRepository.GetByID(entity.ID);
                    source.RegionCode = entity.RegionCode ?? string.Empty;
                    source.CompCode = entity.CompCode ?? string.Empty;
                    source.CompEngShortTitle = entity.CompEngShortTitle ?? string.Empty;
                    source.CompEngFullTitle = entity.CompEngFullTitle ?? string.Empty;
                    source.CompLocShortTitle = entity.CompLocShortTitle ?? string.Empty;
                    source.CompLocFullTitle = entity.CompLocFullTitle ?? string.Empty;
                    source.GUINo = entity.GUINo ?? string.Empty;
                    source.TelNo = entity.TelNo ?? string.Empty;
                    source.FaxNo = entity.FaxNo ?? string.Empty;
                    source.Address = entity.Address ?? string.Empty;
                    source.UpdateUser = entity.UpdateUser ?? string.Empty;
                    source.UpdateTime = entity.UpdateTime;

                    _companyRepository.Update(source);
                    transaction.Commit();
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