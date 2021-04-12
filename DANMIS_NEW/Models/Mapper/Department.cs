#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Generated at 11/06/2017 14:27:06
//       Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DANMIS_NEW.ViewModel;
using DANMIS_NEW.ViewModel.Struct;

namespace DANMIS_NEW.Models
{
    public partial class Department
    {
        /// <summary>
        /// 將 ViewModel 轉換為 Model 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Department Convert(DepartmentViewModel source)
        {
            return source == null ? null : new Department
            {
                SequenceNo = source.SequenceNo,
                ID = source.ID,
                Sequence = source.Sequence,
                Name = source.Name ?? string.Empty,
                Abbreviate = source.Abbreviate ?? string.Empty,
                DepartmentLevel = source.DepartmentLevel,
                ContactTel = source.ContactTel ?? string.Empty,
                ContactFax = source.ContactFax ?? string.Empty,
                Address = source.Address ?? string.Empty,
                WebSiteUrl = source.WebSiteUrl ?? string.Empty,
                ImagePath = source.ImagePath ?? string.Empty,
                ImageAlt = source.ImageAlt ?? string.Empty,
                ImageWidth = source.ImageWidth,
                ImageHeight = source.ImageHeight,
                Description = source.Description ?? string.Empty,
                IsEnable = source.IsEnable,
                CreateUser = source.CreateUser ?? string.Empty,
                CreateTime = source.CreateTime,
                UpdateUser = source.UpdateUser ?? string.Empty,
                UpdateTime = source.UpdateTime,
                FreeFields = null == source.FreeFields ? "{}" : source.FreeFields.ToString(),
                HeadID = source.HeadID,
                ParentID = source.ParentID,
            };
        }

        /// <summary>
        /// 將 Model 轉換為 ViewModel 物件
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DepartmentViewModel Convert(Department source)
        {
            var freeFields = null != source && !string.IsNullOrEmpty(source.FreeFields) ?
                new TemplateFields(source.FreeFields) :
                new TemplateFields();

            return source == null ? null : new DepartmentViewModel
            {
                SequenceNo = source.SequenceNo,
                ID = source.ID,
                Sequence = source.Sequence,
                Name = source.Name ?? string.Empty,
                Abbreviate = source.Abbreviate ?? string.Empty,
                DepartmentLevel = source.DepartmentLevel,
                ContactTel = source.ContactTel ?? string.Empty,
                ContactFax = source.ContactFax ?? string.Empty,
                Address = source.Address ?? string.Empty,
                WebSiteUrl = source.WebSiteUrl ?? string.Empty,
                ImagePath = source.ImagePath ?? string.Empty,
                ImageAlt = source.ImageAlt ?? string.Empty,
                ImageWidth = source.ImageWidth,
                ImageHeight = source.ImageHeight,
                Description = source.Description ?? string.Empty,
                IsEnable = source.IsEnable,
                CreateUser = source.CreateUser ?? string.Empty,
                CreateTime = source.CreateTime,
                UpdateUser = source.UpdateUser ?? string.Empty,
                UpdateTime = source.UpdateTime,
                FreeFields = freeFields,
                HeadID = source.HeadID,
                ParentID = source.ParentID,
            };
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator Department(DepartmentViewModel source)
        {
            return Convert(source);
        }

        /// <summary>
        /// 轉換運算子
        /// </summary>
        /// <param name="source"></param>
        public static explicit operator DepartmentViewModel(Department source)
        {
            return Convert(source);
        }
    }
}
#pragma warning restore 1591