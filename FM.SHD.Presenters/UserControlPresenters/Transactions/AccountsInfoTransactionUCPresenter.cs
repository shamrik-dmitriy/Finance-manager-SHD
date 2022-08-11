using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;

        public AccountsInfoTransactionUCPresenter(IAccountsInfoTransactionUCView accountsInfoTransactionUcView)
        {
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
        }

        public IAccountsInfoTransactionUCView GetUserControlView()
        {
            return _accountsInfoTransactionUcView;
        }
    }
}