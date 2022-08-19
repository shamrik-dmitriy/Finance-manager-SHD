using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ICategoryUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetLabelText(string text);
        (int, string) GetCategoryInfo();
        void SetDataSource(IEnumerable<BaseDto> value);
        void SetVisible(bool isVisible);
    }
}