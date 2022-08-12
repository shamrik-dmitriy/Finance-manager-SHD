using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;
        private readonly IAccountInfoUCPresenter _debitAccountInfoUcPresenter;
        private readonly ISumTransactionUCPresenter _sumTransactionUcPresenter;
        private readonly IAccountInfoUCPresenter _creditAccountInfoUcPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcView;

        public AccountsInfoTransactionUCPresenter(
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            IAccountInfoUCPresenter debitAccountInfoUcPresenter,
            ISumTransactionUCPresenter sumTransactionUcPresenter,
            IAccountInfoUCPresenter creditAccountInfoUcPresenter,
            IDateTransactionUCPresenter dateTransactionUcView)
        {
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
            _accountServices = accountServices;
            _debitAccountInfoUcPresenter = debitAccountInfoUcPresenter;
            _sumTransactionUcPresenter = sumTransactionUcPresenter;
            _creditAccountInfoUcPresenter = creditAccountInfoUcPresenter;
            _dateTransactionUcView = dateTransactionUcView;

            _accountsInfoTransactionUcView.LoadUserControlView += AccountsInfoUcViewOnLoadControlView;
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