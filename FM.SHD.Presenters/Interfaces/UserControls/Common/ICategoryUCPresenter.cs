using System;
using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.CommonServices;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ICategoryUCPresenter<T> where T : ICategoryServices
    {
        event Action<long> CategoryChanged;

        void SetCategoryValues();
        
        ICategoryUCView GetUserControlView();

        void SetText(string text);
        (int Index, string Name) GetCategoryInfo();
        
        void SetVisible(bool isVisible);
        
        
        #region DropDown styles

        void SetStyleDropDownList();
        void SetStyleDropDown();

        #endregion
    }
}