#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 03/04/2021 15:24:54
//       Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.ViewModel;

namespace DANMIS_NEW.Models
{
    public partial class BrandData
    {
        /// <summary>
        /// 將 ViewModel 轉換為 Model 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static BrandData Convert(BrandDataViewModel source)
        {
            return source == null ? null : new BrandData
            {
                BrandName = source.BrandName ?? string.Empty,
                EntityCode = source.EntityCode ?? string.Empty,
                GroupName = source.GroupName ?? string.Empty,
                ProjectOwnerEmail = source.ProjectOwnerEmail ?? string.Empty,
                Year = source.Year,
                SeqNo = source.SeqNo,
            };
        }

        /// <summary>
        /// 將 Model 轉換為 ViewModel 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static BrandDataViewModel Convert(BrandData source)
        {
            return source == null ? null : new BrandDataViewModel
            {
                BrandName = source.BrandName ?? string.Empty,
                EntityCode = source.EntityCode ?? string.Empty,
                GroupName = source.GroupName ?? string.Empty,
                ProjectOwnerEmail = source.ProjectOwnerEmail ?? string.Empty,
                Year = source.Year,
                SeqNo = source.SeqNo,
            };
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator BrandData(BrandDataViewModel source)
        {
            return Convert(source);
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator BrandDataViewModel(BrandData source)
        {
            return Convert(source);
        }
    }
}
#pragma warning restore 1591