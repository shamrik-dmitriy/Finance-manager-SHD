using System;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface IDataControlButtonsUCView : IUserControlView
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