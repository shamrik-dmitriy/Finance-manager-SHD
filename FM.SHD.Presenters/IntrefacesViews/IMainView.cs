using System;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IMainView : IView
    {
        event EventHandler AddTransaction;
    }
}