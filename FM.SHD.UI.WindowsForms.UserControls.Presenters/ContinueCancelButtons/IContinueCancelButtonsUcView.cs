using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons
{
    public interface IContinueCancelButtonsUcView : IUserControlView
    {
        event Action Continue;
        event Action Cancel;
        event Action Delete;
        
        void CloseParentView();
        void SetTextButtonCancel(string text);
        void SetTextButtonContinue(string text);
        void SetVisibleButtonDelete(bool isVisible);
        void SetTextButtonDelete(string text);
    }
}