using System;
using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.NewViews
{
    public interface ISingleTransactionView : IView
    {
        event Action OnLoadView;
        event EventHandler Add;
        event Action<int> OnChangeTypeTransaction;

        void AddUserControl(IUserControlView userControlView);
        SingleTransactionDto GetTransactionInfo();
        void SetTitle(string title);
    }
}