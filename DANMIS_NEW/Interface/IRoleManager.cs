#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 09/25/2017 13:04:04
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.ListResult;
using DANMIS_NEW.ViewModel.SearchModel;
using System;
using System.Collections.Generic;

namespace DANMIS_NEW.Interface
{
    public interface IRoleManager : IManager
    {
        /// <summary>
        /// 建立 Role
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Create(RoleViewModel entity);

        /// <summary>
        /// 根據 id 刪除 Role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(List<Guid> id);

        /// <summary>
        /// 取得角色對應的 Function ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Guid> GetAccessFunctionByRoleID(Guid? id = null);

        /// <summary>
        /// 根據 id 取得 Role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        RoleViewModel GetByID(Guid id);

        /// <summary>
        /// 取得模組與功能對應的 Dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, List<FunctionViewModel>> GetFunctionMappingToModule();

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        Paging<RoleListResult> Paging(RoleSearchModel searchModel);

        /// <summary>
        /// 更新 Role
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(RoleViewModel entity);
    }
}
#pragma warning restore 1591