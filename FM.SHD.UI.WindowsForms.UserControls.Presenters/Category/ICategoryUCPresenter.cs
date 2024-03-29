using System;
using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category
{
    public interface ICategoryUCPresenter<T> where T : IBaseCategoryServices
    {
        event Action<long> CategoryChanged;

        void SetCategoryValues();

        ICategoryUCView GetUserControlView();

        void SetText(string text);
        long? GetCategoryId(bool isPossibleNull = false);
        BaseDto GetCategoryDto();

        void SetVisible(bool isVisible);

        #region DropDown styles

        void SetStyleDropDownList();
        void SetStyleDropDown();

        #endregion
    }
}