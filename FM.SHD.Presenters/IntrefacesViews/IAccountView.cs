using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IAccountView : IView
    {
        event Action OnLoadView;
        event Action OnClosingView;

        void AddUserControl(IUserControlView userControlView);
 
    }
}