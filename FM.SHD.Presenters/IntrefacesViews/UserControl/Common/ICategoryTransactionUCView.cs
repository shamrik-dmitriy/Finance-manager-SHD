using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ICategoryTransactionUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetLabelText(string text);
        (long, string) GetCategoryInfo();
        void SetCategoryValues(IEnumerable<BaseCategoryDto> value);

        void SetVisible(bool isVisible);
    }
}