using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Services.AccountServices;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory.Events;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Additional.UserControls
{
    public class AccountsInfoTransactionUCPresenter : IAccountsInfoTransactionUCPresenter
    {
        private readonly EventAggregator _eventAggregator;
        private readonly IAccountsInfoTransactionUCView _accountsInfoTransactionUcView;
        private readonly IAccountServices _accountServices;

        private readonly ICategoryComboboxUCPresenter<AccountServices> _debitAccountInfoComboboxUCPresenter;
        private readonly ISumTransactionUCPresenter _sumTransactionUcPresenter;
        private readonly ICategoryComboboxUCPresenter<AccountServices> _creditAccountInfoComboboxUCPresenter;
        private readonly IDateTransactionUCPresenter _dateTransactionUcPresenter;

        public AccountsInfoTransactionUCPresenter(
            EventAggregator eventAggregator,
            IAccountsInfoTransactionUCView accountsInfoTransactionUcView,
            IAccountServices accountServices,
            ICategoryComboboxUCPresenter<AccountServices> debitAccountInfoComboboxUCPresenter,
            ISumTransactionUCPresenter sumTransactionUcPresenter,
            ICategoryComboboxUCPresenter<AccountServices> creditAccountInfoComboboxUCPresenter,
            IDateTransactionUCPresenter dateTransactionUcPresenter)
        {
            _eventAggregator = eventAggregator;
            _accountsInfoTransactionUcView = accountsInfoTransactionUcView;
            _accountServices = accountServices;
            _debitAccountInfoComboboxUCPresenter = debitAccountInfoComboboxUCPresenter;
            _sumTransactionUcPresenter = sumTransactionUcPresenter;
            _creditAccountInfoComboboxUCPresenter = creditAccountInfoComboboxUCPresenter;
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
                    _creditAccountInfoComboboxUCPresenter.SetText("Списать со счёта");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(false);
                    break;
                }
                case 1:
                {
                    //_creditAccountInfoComboboxUCPresenter.SetText("Зачислить на счёт");
                    //_debitAccountInfoComboboxUCPresenter.SetVisible(false);

                    _creditAccountInfoComboboxUCPresenter.SetText("Списать со счёта");
                    _debitAccountInfoComboboxUCPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(true);
                    break;
                }
                case 2:
                {
                    _creditAccountInfoComboboxUCPresenter.SetText("Списать со счёта");
                    _debitAccountInfoComboboxUCPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(true);
                    break;
                }
            }
        }

        private void AccountsInfoUcViewOnOnLoadControlView()
        {
            _debitAccountInfoComboboxUCPresenter.SetStyleDropDownList();
            _debitAccountInfoComboboxUCPresenter.SetCategoryValues();
            _debitAccountInfoComboboxUCPresenter.GetUserControlView().SetCategoryFirst();
            _accountsInfoTransactionUcView.AddAccountInfo(_debitAccountInfoComboboxUCPresenter.GetUserControlView());

            _creditAccountInfoComboboxUCPresenter.SetStyleDropDownList();
            _creditAccountInfoComboboxUCPresenter.SetCategoryValues();
            _creditAccountInfoComboboxUCPresenter.GetUserControlView().SetCategoryFirst();
            _accountsInfoTransactionUcView.AddAccountInfo(_creditAccountInfoComboboxUCPresenter.GetUserControlView());

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
                    _debitAccountInfoComboboxUCPresenter.SetText("Списать со счёта");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(true);
                    _creditAccountInfoComboboxUCPresenter.SetVisible(false);
                    break;
                }
                case 2:
                {
                    _creditAccountInfoComboboxUCPresenter.SetText("Зачислить на счёт");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(false);
                    _creditAccountInfoComboboxUCPresenter.SetVisible(true);

                    break;
                }
                case 3:
                {
                    _debitAccountInfoComboboxUCPresenter.SetText("Списать со счёта");
                    _debitAccountInfoComboboxUCPresenter.SetVisible(true);

                    _creditAccountInfoComboboxUCPresenter.SetText("Зачислить на счёт");
                    _creditAccountInfoComboboxUCPresenter.SetVisible(true);
                    break;
                }
            }
        }

        public long? GetDebitAccountId()
        {
            // TODO: Переписать
            return _debitAccountInfoComboboxUCPresenter.GetCategoryId(true);
        }

        public long? GetCreditAccountId()
        {
            return _creditAccountInfoComboboxUCPresenter.GetCategoryId();
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
            _creditAccountInfoComboboxUCPresenter.SetCategoryValues();
            _creditAccountInfoComboboxUCPresenter.GetUserControlView().SetCategoryId(creditAccountId);
        }

        public void SetDebitAccountId(long? debitAccountId)
        {
            _debitAccountInfoComboboxUCPresenter.SetCategoryValues();
            _debitAccountInfoComboboxUCPresenter.GetUserControlView().SetCategoryId(debitAccountId);
        }

        public event Action<long> CategoryChanged;
    }
}