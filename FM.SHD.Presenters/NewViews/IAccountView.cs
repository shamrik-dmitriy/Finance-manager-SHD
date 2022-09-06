using System;
using FM.SHD.Presenters.Common;

namespace FM.SHD.Presenters.NewViews
{
    public interface IAccountView : IView
    {
        event Action OnLoadView;
        event Action OnClosingView;
        void SetTitle(string title);
    }
}