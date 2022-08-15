using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly EventAggregator _eventAggregator;
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;
        private readonly IAccountInfoUCPresenter _debitAccountInfoUcPresenter;
        private readonly ISumTransactionUCPresenter _sumTransactionUcPresenter;
        private readonly IAccountInfoUCPresenter _creditAccountInfoUcPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcPresenter;

        public AccountsInfoTransactionUCPresenter(
            EventAggregator eventAggregator,
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            IAccountInfoUCPresenter debitAccountInfoUcPresenter,
            ISumTransactionUCPresenter sumTransactionUcPresenter,
            IAccountInfoUCPresenter creditAccountInfoUcPresenter,
            IDateTransactionUCPresenter dateTransactionUcPresenter)
        {
            _eventAggregator = eventAggregator;
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
            _accountServices = accountServices;
            _debitAccountInfoUcPresenter = debitAccountInfoUcPresenter;
            _sumTransactionUcPresenter = sumTransactionUcPresenter;
            _creditAccountInfoUcPresenter = creditAccountInfoUcPresenter;
            _dateTransactionUcPresenter = dateTransactionUcPresenter;

            _accountsInfoTransactionUcView.OnLoadUserControlView += AccountsInfoUcViewOnOnLoadControlView;

            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe<OnSelectedTypeOfTransactionApplicationEvent>(
                OnSelectedTypeOfTransactionApplicationEvent);
        }

        private void OnSelectedTypeOfTransactionApplicationEvent(OnSelectedTypeOfTransactionApplicationEvent obj)
        {
            switch (obj.TypeOfTransaction)
            {
                case 0:
                {
                    _creditAccountInfoUcPresenter.SetText("Списать со счёта");
                    _debitAccountInfoUcPresenter.SetVisible(false);
                    break;
                }
                case 1:
                {
                    _creditAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoUcPresenter.SetVisible(false);
                    break;
                }
                case 2:
                {
                    _creditAccountInfoUcPresenter.SetText("Списать со счёта");
                    _debitAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoUcPresenter.SetVisible(true);
                    break;
                }
            }

            //  financeInfoOfOperationflowLayoutPanel.Refresh();
           //  financeInfoOfOperationflowLayoutPanel.Update();
        }
        
        private void AccountsInfoUcViewOnOnLoadControlView()
        {
            _accountsInfoTransactionUcView.AddAccountInfo(_creditAccountInfoUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddSumm(_sumTransactionUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddAccountInfo(_debitAccountInfoUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddDate(_dateTransactionUcPresenter.GetUserControlView());
            //_accountsInfoTransactionUcView.SetAccounts(_accountServices.GetAll());
        }

        public IAccountsInfoTransactionUCView GetUserControlView()
        {
            return _accountsInfoTransactionUcView;
        }
    }
}