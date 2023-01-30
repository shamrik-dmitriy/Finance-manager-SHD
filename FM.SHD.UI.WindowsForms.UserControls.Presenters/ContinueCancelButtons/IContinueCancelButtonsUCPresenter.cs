using System;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons
{
    public interface IContinueCancelButtonsUCPresenter
    {
        IContinueCancelButtonsUcView GetUserControlView();
        event Action Continue;
        event Action Delete;
        void SetVisibleButtonDelete(bool isVisible);
        void SetTextButtonDelete(string text);
        void SetTextButtonContinue(string text);
        void SetTextButtonCancel(string text);
    }
}