using System;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface IAddCancelButtonsUCView : IUserControlView
    {
        event Action Continue;
        event Action Cancel;
        void CloseParentView();
    }
}