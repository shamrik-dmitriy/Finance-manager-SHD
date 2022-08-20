using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.Interfaces.UserControls.Transactions
{
    public interface IAccountsInfoTransactionUCPresenter
    {
        IAccountsInfoTransactionUCView GetUserControlView();

        void CategoryChanged(long id);
    }
}