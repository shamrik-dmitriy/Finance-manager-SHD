using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;

        public AccountsInfoTransactionUCPresenter(
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices)
        {
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
            _accountServices = accountServices;
            
            _accountsInfoTransactionUcView.LoadUserControlView +=AccountsInfoUcViewOnLoadControlView;
        }

        private void AccountsInfoUcViewOnLoadControlView()
        {
            _accountsInfoTransactionUcView.SetAccounts(_accountServices.GetAll());
        }

        public IAccountsInfoTransactionUCView GetUserControlView()
        {
            return _accountsInfoTransactionUcView;
        }
    }
}