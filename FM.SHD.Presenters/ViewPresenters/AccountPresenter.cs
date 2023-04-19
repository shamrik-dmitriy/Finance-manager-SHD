using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events.Accounts;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CurrencyServices;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Checkbox;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Description;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Label;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class AccountPresenter : BaseAccountPresenter
    {
        #region Private member variable

        private readonly IAccountServices _accountServices;
        private readonly EventAggregator _eventAggregator;
        private readonly IAccountBaseView _baseView;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly ILabelTextboxUcPresenter _labelTextboxUcPresenter;
        private readonly ICategoryUCPresenter<AccountCategoryServices> _accountUcPresenter;
        private readonly ICategoryUCPresenter<CurrencyServices> _currencyUcPresenter;
        private readonly ICheckboxUCPresenter _checkboxUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _dataControlButtonsUcPresenter;

        #endregion

        #region Constructor

        public AccountPresenter(
            EventAggregator eventAggregator,
            IAccountBaseView baseView,
            IAccountServices accountServices,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            ILabelTextboxUcPresenter labelTextboxUcPresenter,
            ICategoryUCPresenter<AccountCategoryServices> accountUcPresenter,
            ICategoryUCPresenter<CurrencyServices> currencyUcPresenter,
            ICheckboxUCPresenter checkboxUcPresenter,
            IContinueCancelButtonsUCPresenter dataControlButtonsUcPresenter
        )
            : base(baseView)
        {
            _eventAggregator = eventAggregator;
            _baseView = baseView;
            _accountServices = accountServices;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _labelTextboxUcPresenter = labelTextboxUcPresenter;
            _accountUcPresenter = accountUcPresenter;
            _currencyUcPresenter = currencyUcPresenter;
            _checkboxUcPresenter = checkboxUcPresenter;
            _dataControlButtonsUcPresenter = dataControlButtonsUcPresenter;

            _baseView.OnLoadView += OnLoadBaseView;
        }

        ~AccountPresenter()
        {
            _baseView.OnLoadView -= OnLoadBaseView;
        }

        #endregion

        #region Private methods

        private void OnLoadBaseView()
        {
            _labelTextboxUcPresenter.SetText("Начальная сумма");
            _accountUcPresenter.SetText("Категория счёта");
            _currencyUcPresenter.SetText("Валюта");
            _checkboxUcPresenter.SetText("Закрытый счёт");

            if (AccountDto != null)
            {
                _baseView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(AccountDto.Name);

                _baseView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(AccountDto.Description);

                _baseView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
                _labelTextboxUcPresenter.SetValue(AccountDto.InitialSum.ToString());

                _accountUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_accountUcPresenter.GetUserControlView());
                _accountUcPresenter.GetUserControlView().SetCategoryId(AccountDto.CategoryId);

                _currencyUcPresenter.SetCategoryValues();
                _currencyUcPresenter.SetStyleDropDownList();
                _baseView.AddUserControl(_currencyUcPresenter.GetUserControlView());
                _currencyUcPresenter.GetUserControlView().SetCategoryId(AccountDto.CurrencyId);

                _checkboxUcPresenter.GetUserControlView().SetCheckboxState(AccountDto.IsClosed);
                _baseView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
                _dataControlButtonsUcPresenter.SetTextButtonContinue("Применить");
                _baseView.AddUserControl(_dataControlButtonsUcPresenter.GetUserControlView());
            }
            else
            {
                _baseView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _baseView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _baseView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
                _accountUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_accountUcPresenter.GetUserControlView());
                _currencyUcPresenter.SetStyleDropDownList();
                _currencyUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_currencyUcPresenter.GetUserControlView());
                _baseView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
                _dataControlButtonsUcPresenter.SetVisibleButtonDelete(false);
                _baseView.AddUserControl(_dataControlButtonsUcPresenter.GetUserControlView());
            }

            _dataControlButtonsUcPresenter.Continue += DataControlButtonsUcPresenterOnContinue;
            _dataControlButtonsUcPresenter.Delete += DataControlsButtonsUcPresenterOnDelete;
            _currencyUcPresenter.CategoryChanged += CurrencyUcPresenterOnCategoryChanged;
        }

        private void DataControlsButtonsUcPresenterOnDelete()
        {
            if (_baseView.ShowMessageDelete("Удаление счёта", $"Счёт \"{AccountDto.Name}\" будет удален, продолжить?"))
            {
                _accountServices.DeleteById(AccountDto.Id);
                _eventAggregator.Publish(new OnDeletingAccountApplicationEvent());
                _baseView.Close();
            }
        }

        private void CurrencyUcPresenterOnCategoryChanged(long id)
        {
        }

        private void DataControlButtonsUcPresenterOnContinue()
        {
            if (AccountDto != null)
            {
                AccountDto.Name = _nameUcPresenter.GetName();
                AccountDto.Description = _descriptionUcPresenter.GetDescription();
                AccountDto.InitialSum = Convert.ToDecimal(_labelTextboxUcPresenter.GetTextBoxValue());
                AccountDto.CurrencyId = ((CurrencyDto)_currencyUcPresenter.GetCategoryDto()).Id;
                AccountDto.CategoryId = ((AccountCategoryDto)_accountUcPresenter.GetCategoryDto()).Id;
                AccountDto.IdentityId = 1;
                AccountDto.IsClosed = Convert.ToBoolean(_checkboxUcPresenter.GetCheckboxState());
                _accountServices.Update(AccountDto);
                _eventAggregator.Publish(new OnChangingAccountApplicationEvent());
            }
            else
            {
                _accountServices.Add(new AccountDto()
                {
                    Name = _nameUcPresenter.GetName(),
                    Description = _descriptionUcPresenter.GetDescription(),
                    InitialSum = Convert.ToDecimal(_labelTextboxUcPresenter.GetTextBoxValue()),
                    CurrencyId = _currencyUcPresenter.GetCategoryId(),
                    CategoryId = _accountUcPresenter.GetCategoryId(),
                    IdentityId = 1,
                    IsClosed = Convert.ToBoolean(_checkboxUcPresenter.GetCheckboxState())
                });
                _eventAggregator.Publish(new OnAddedAccountApplicationEvent());
            }

            _dataControlButtonsUcPresenter.Continue -= DataControlButtonsUcPresenterOnContinue;
            _dataControlButtonsUcPresenter.Delete -= DataControlsButtonsUcPresenterOnDelete;
            _currencyUcPresenter.CategoryChanged -= CurrencyUcPresenterOnCategoryChanged;

            _baseView.Close();
        }

        public AccountDto AccountDto { get; set; }

        #endregion

        public override void Run(AccountDto categoryDto)
        {
            AccountDto = categoryDto;
            _baseView.Show();
        }

        public override void Run(string title, AccountDto transactionDto = default(AccountDto))
        {
            AccountDto = transactionDto;
            _baseView.SetTitle(title);
            _baseView.Show();
        }
    }
}