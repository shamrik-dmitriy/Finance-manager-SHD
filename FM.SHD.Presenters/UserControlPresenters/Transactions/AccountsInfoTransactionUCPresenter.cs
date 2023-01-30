using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Events;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly EventAggregator _eventAggregator;
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;

        private readonly ICategoryUCPresenter<AccountServices> _debitAccountInfoUcPresenter;
        private readonly ISumTransactionUCPresenter _sumTransactionUcPresenter;
        private readonly ICategoryUCPresenter<AccountServices> _creditAccountInfoUcPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcPresenter;

        public AccountsInfoTransactionUCPresenter(
            EventAggregator eventAggregator,
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            ICategoryUCPresenter<AccountServices> debitAccountInfoUcPresenter,
            ISumTransactionUCPresenter sumTransactionUcPresenter,
            ICategoryUCPresenter<AccountServices> creditAccountInfoUcPresenter,
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
                    //_creditAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    //_debitAccountInfoUcPresenter.SetVisible(false);
                    
                    _creditAccountInfoUcPresenter.SetText("Списать со счёта");
                    _debitAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoUcPresenter.SetVisible(true);
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
            _debitAccountInfoUcPresenter.SetStyleDropDownList();
            _accountsInfoTransactionUcView.AddAccountInfo(_debitAccountInfoUcPresenter.GetUserControlView());
            
            _creditAccountInfoUcPresenter.SetStyleDropDownList();
            _accountsInfoTransactionUcView.AddAccountInfo(_creditAccountInfoUcPresenter.GetUserControlView());
            
            _accountsInfoTransactionUcView.AddSumm(_sumTransactionUcPresenter.GetUserControlView());

            _accountsInfoTransactionUcView.AddDate(_dateTransactionUcPresenter.GetUserControlView());
        }

        public IAccountsInfoTransactionUCView GetUserControlView()
        {
            return _accountsInfoTransactionUcView;
        }

        void IAccountsInfoTransactionUCPresenter.CategoryChanged(long id)
        {
            switch (id)
            {
                case 1:
                {
                    _debitAccountInfoUcPresenter.SetText("Списать со счёта");
                    _debitAccountInfoUcPresenter.SetVisible(true);
                    _creditAccountInfoUcPresenter.SetVisible(false);
                    break;
                }
                case 2:
                {
                    _creditAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoUcPresenter.SetVisible(false);
                    _creditAccountInfoUcPresenter.SetVisible(true);
                    
                    break;
                }
                case 3:
                {
                    _debitAccountInfoUcPresenter.SetText("Списать со счёта");
                    _debitAccountInfoUcPresenter.SetVisible(true);

                    _creditAccountInfoUcPresenter.SetText("Зачислить на счёт");
                    _creditAccountInfoUcPresenter.SetVisible(true);
                    break;
                }
            }
        }

        public long? GetDebitAccountId()
        {
            // TODO: Переписать
            return _debitAccountInfoUcPresenter.GetCategoryId(true);
        }

        public long? GetCreditAccountId()
        {
            return _creditAccountInfoUcPresenter.GetCategoryId();
        }

        public decimal GetSum()
        {
            return _sumTransactionUcPresenter.GetSum();
        }

        public DateTime GetDate()
        {
            return _dateTransactionUcPresenter.GetDate();
        }

        public void SetDate(DateTime date)
        {
            _dateTransactionUcPresenter.SetDate(date);
        }

        public void SetSum(decimal sum)
        {
            _sumTransactionUcPresenter.SetSum(sum);
        }

        public void SetCreditAccountId(long? creditAccountId)
        {
            _creditAccountInfoUcPresenter.SetCategoryValues();
            _creditAccountInfoUcPresenter.GetUserControlView().SetCategoryId(creditAccountId);
        }

        public void SetDebitAccountId(long? debitAccountId)
        {
            _debitAccountInfoUcPresenter.SetCategoryValues();
            _debitAccountInfoUcPresenter.GetUserControlView().SetCategoryId(debitAccountId);
        }

        public event Action<long> CategoryChanged;
    }
}