using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
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
        private readonly ICategoryUCPresenter _debitAccountInfoUcPresenter;
        private readonly ILabelTextboxUcPresenter _sumTransactionUcPresenter;
        private readonly ICategoryUCPresenter _creditAccountInfoUcPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcPresenter;

        public AccountsInfoTransactionUCPresenter(
            EventAggregator eventAggregator,
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            ICategoryUCPresenter debitAccountInfoUcPresenter,
            ILabelTextboxUcPresenter sumTransactionUcPresenter,
            ICategoryUCPresenter creditAccountInfoUcPresenter,
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
        }

        private void AccountsInfoUcViewOnOnLoadControlView()
        {
            _accountsInfoTransactionUcView.AddUserControl(_creditAccountInfoUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddUserControl(_sumTransactionUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddUserControl(_debitAccountInfoUcPresenter.GetUserControlView());
            _accountsInfoTransactionUcView.AddUserControl(_dateTransactionUcPresenter.GetUserControlView());
        }

        public IAccountsInfoTransactionUCView GetUserControlView()
        {
            return _accountsInfoTransactionUcView;
        }

        public long GetCreditAccount()
        {
            return _creditAccountInfoUcPresenter.GetCategoryInfo().Id;
        }

        public long GetDebitAccount()
        {
            return _debitAccountInfoUcPresenter.GetCategoryInfo().Id;
        }

        public string GetSum()
        {
            return _sumTransactionUcPresenter.GetTextBoxValue();
        }

        public DateTime GetDate()
        {
            return _dateTransactionUcPresenter.GetDateTime();
        }
    }
}