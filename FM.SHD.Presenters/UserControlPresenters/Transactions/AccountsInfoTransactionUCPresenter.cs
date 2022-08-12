using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;
        private readonly IAccountsInfoTransactionUCPresenter _debitAccountsInfoTransactionUcPresenter;
        private readonly ISumTransactionUCPresenter _sumTransactionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _creditAccountsInfoTransactionUcPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcView;

        public AccountsInfoTransactionUCPresenter(
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            IAccountsInfoTransactionUCPresenter debitAccountsInfoTransactionUcPresenter,
            ISumTransactionUCPresenter sumTransactionUcPresenter,
            IAccountsInfoTransactionUCPresenter creditAccountsInfoTransactionUcPresenter,
            IDateTransactionUCPresenter dateTransactionUcView)
        {
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
            _accountServices = accountServices;
            _debitAccountsInfoTransactionUcPresenter = debitAccountsInfoTransactionUcPresenter;
            _sumTransactionUcPresenter = sumTransactionUcPresenter;
            _creditAccountsInfoTransactionUcPresenter = creditAccountsInfoTransactionUcPresenter;
            _dateTransactionUcView = dateTransactionUcView;

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