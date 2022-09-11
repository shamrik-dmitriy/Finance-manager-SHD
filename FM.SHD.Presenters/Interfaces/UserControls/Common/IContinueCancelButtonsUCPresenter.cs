using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface IContinueCancelButtonsUCPresenter
    {
        IDataControlButtonsUCView GetUserControlView();
        event Action Continue;
        event Action Delete;
        void SetVisibleButtonDelete(bool isVisible);
        void SetTextButtonDelete(string text);
        void SetTextButtonContinue(string text);
        void SetTextButtonCancel(string text);
    }
}