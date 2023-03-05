using System;
using FM.SHD.UI.WindowsForms.Presenters;


namespace FM.SHD.Presenters.IntrefacesViews.Views
{
    public interface IAccountBaseView : IBaseView
    {
        event Action OnLoadView;
        event Action OnClosingView;
        bool ShowMessageDelete(string title, string message);
    }
}