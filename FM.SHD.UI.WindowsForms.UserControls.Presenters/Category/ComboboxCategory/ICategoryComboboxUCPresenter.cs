using System;
using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory
{
    public interface ICategoryComboboxUCPresenter<T> where T : IBaseCategoryServices
    {
        event Action<long> CategoryChanged;

        void SetCategoryValues();

        ICategoryComboboxUCView GetUserControlView();

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