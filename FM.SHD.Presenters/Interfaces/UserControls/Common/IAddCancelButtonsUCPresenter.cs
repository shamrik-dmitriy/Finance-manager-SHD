using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface IAddCancelButtonsUCPresenter
    {
        IAddCancelButtonsUCView GetUserControlView();

        event Action Continue;
    }
}