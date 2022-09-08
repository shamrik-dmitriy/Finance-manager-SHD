using System;
using FM.SHD.Presenters.Common;

namespace FM.SHD.Presenters.IntrefacesViews.Views
{
    public interface IAccountView : IView
    {
        event Action OnLoadView;
        event Action OnClosingView;
    }
}