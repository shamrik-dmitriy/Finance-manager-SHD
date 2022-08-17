using System;
using System.Collections.Generic;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ICategoryTransactionUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetLabelText(string text);
        (int, string) GetCategoryInfo();
        void SetCategoryValues(IEnumerable<string> value);
    }
}