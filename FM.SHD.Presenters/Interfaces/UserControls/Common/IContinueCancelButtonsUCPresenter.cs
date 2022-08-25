using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface IContinueCancelButtonsUCPresenter
    {
        IAddCancelButtonsUCView GetUserControlView();

        event Action Continue;
        void SetTextButtonContinue(string text);
        void SetTextButtonCancel(string text);
    }
}