using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ICategoryUCPresenter
    {
        void SetCategoryValues();
        
        ICategoryTransactionUCView GetUserControlView();

        void SetText(string text);
        (int Index, string Name) GetCategoryInfo();
    }
}