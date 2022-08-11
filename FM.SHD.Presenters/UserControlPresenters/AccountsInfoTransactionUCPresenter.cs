using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
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