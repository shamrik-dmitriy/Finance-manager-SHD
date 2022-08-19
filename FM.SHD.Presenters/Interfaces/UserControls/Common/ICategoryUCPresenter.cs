using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ICategoryUCPresenter
    {
        void SetCategoryValues();
        
        ICategoryTransactionUCView GetUserControlView();

        void SetText(string text);
        (long Id, string Name) GetCategoryInfo();
        void SetVisible(bool isVisible);
    }
}