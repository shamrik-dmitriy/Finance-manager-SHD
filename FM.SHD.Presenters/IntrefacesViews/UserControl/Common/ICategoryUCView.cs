using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ICategoryUCView : IUserControlView
    {
        #region Events

        event Action OnLoadUserControlView;
        event Action<long> SelectedIndexChanged;

        #endregion

        #region Data actions

        void SetLabelText(string text);
        long? GetCategoryId();
        void SetDataSource(IEnumerable<BaseDto> value);

        #endregion

        #region UI

        void SetVisible(bool isVisible);

        #endregion

        #region DropDown styles

        void SetStyleDropDownList();
        void SetStyleDropDown();

        #endregion

        void SetCategoryId(BaseDto baseDto);
    }
}