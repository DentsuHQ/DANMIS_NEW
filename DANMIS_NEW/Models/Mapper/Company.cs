#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 04/15/2021 18:55:24
//       Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.ViewModel;

namespace DANMIS_NEW.Models
{
    public partial class Company
    {
        /// <summary>
        /// 將 ViewModel 轉換為 Model 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Company Convert(CompanyViewModel source)
        {
            return source == null ? null : new Company
            {
                SequenceNo = source.SequenceNo,
                ID = source.ID,
                RegionCode = source.RegionCode ?? string.Empty,
                CompCode = source.CompCode ?? string.Empty,
                CompEngShortTitle = source.CompEngShortTitle ?? string.Empty,
                CompEngFullTitle = source.CompEngFullTitle ?? string.Empty,
                CompLocShortTitle = source.CompLocShortTitle ?? string.Empty,
                CompLocFullTitle = source.CompLocFullTitle ?? string.Empty,
                GUINo = source.GUINo ?? string.Empty,
                TelNo = source.TelNo ?? string.Empty,
                FaxNo = source.FaxNo ?? string.Empty,
                Address = source.Address ?? string.Empty,
                CreateUser = source.CreateUser ?? string.Empty,
                CreateTime = source.CreateTime,
                UpdateUser = source.UpdateUser ?? string.Empty,
                UpdateTime = source.UpdateTime,
            };
        }

        /// <summary>
        /// 將 Model 轉換為 ViewModel 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static CompanyViewModel Convert(Company source)
        {
            return source == null ? null : new CompanyViewModel
            {
                SequenceNo = source.SequenceNo,
                ID = source.ID,
                RegionCode = source.RegionCode ?? string.Empty,
                CompCode = source.CompCode ?? string.Empty,
                CompEngShortTitle = source.CompEngShortTitle ?? string.Empty,
                CompEngFullTitle = source.CompEngFullTitle ?? string.Empty,
                CompLocShortTitle = source.CompLocShortTitle ?? string.Empty,
                CompLocFullTitle = source.CompLocFullTitle ?? string.Empty,
                GUINo = source.GUINo ?? string.Empty,
                TelNo = source.TelNo ?? string.Empty,
                FaxNo = source.FaxNo ?? string.Empty,
                Address = source.Address ?? string.Empty,
                CreateUser = source.CreateUser ?? string.Empty,
                CreateTime = source.CreateTime,
                UpdateUser = source.UpdateUser ?? string.Empty,
                UpdateTime = source.UpdateTime,
            };
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator Company(CompanyViewModel source)
        {
            return Convert(source);
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator CompanyViewModel(Company source)
        {
            return Convert(source);
        }
    }
}
#pragma warning restore 1591