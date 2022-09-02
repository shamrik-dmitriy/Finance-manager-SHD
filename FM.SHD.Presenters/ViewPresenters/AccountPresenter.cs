using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CurrencyServices;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class AccountPresenter : IAccountPresenter
    {
        private readonly IAccountServices _accountServices;
        private readonly IAccountView _accountView;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly ILabelTextboxUcPresenter _labelTextboxUcPresenter;
        private readonly ICategoryUCPresenter<AccountCategoryServices> _accountUcPresenter;
        private readonly ICategoryUCPresenter<CurrencyServices> _currencyUcPresenter;
        private readonly ICheckboxUCPresenter _checkboxUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        public AccountPresenter(
            IAccountServices accountServices,
            IAccountView accountView,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            ILabelTextboxUcPresenter labelTextboxUcPresenter,
            ICategoryUCPresenter<AccountCategoryServices> accountUcPresenter,
            ICategoryUCPresenter<CurrencyServices> currencyUcPresenter,
            ICheckboxUCPresenter checkboxUcPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter)
        {
            _accountServices = accountServices;
            _accountView = accountView;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _labelTextboxUcPresenter = labelTextboxUcPresenter;
            _accountUcPresenter = accountUcPresenter;
            _currencyUcPresenter = currencyUcPresenter;
            _checkboxUcPresenter = checkboxUcPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;

            _accountView.OnLoadView += AccountViewOnOnLoadView;
        }

        private void AccountViewOnOnLoadView()
        {
            _labelTextboxUcPresenter.SetText("Начальная сумма");
            _accountUcPresenter.SetText("Категория счёта");
            _currencyUcPresenter.SetText("Валюта");
            _checkboxUcPresenter.SetText("Закрытый счёт");

            if (AccountDto != null)
            {
                _accountView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(AccountDto.Name);

                _accountView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(AccountDto.Description);

                _accountView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
                _labelTextboxUcPresenter.SetValue(AccountDto.InitialSum.ToString());

                _accountUcPresenter.SetCategoryValues();
                _accountView.AddUserControl(_accountUcPresenter.GetUserControlView());
                _accountUcPresenter.GetUserControlView().SetCategoryId(AccountDto.CategoryId);

                _currencyUcPresenter.SetCategoryValues();
                _currencyUcPresenter.SetStyleDropDownList();
                _accountView.AddUserControl(_currencyUcPresenter.GetUserControlView());
                _currencyUcPresenter.GetUserControlView().SetCategoryId(AccountDto.CurrencyId);

                _checkboxUcPresenter.GetUserControlView().SetCheckboxState(AccountDto.IsClosed);
                _accountView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
                _accountView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());
            }
            else
            {
                _accountView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _accountView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _accountView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
                _accountUcPresenter.SetCategoryValues();
                _accountView.AddUserControl(_accountUcPresenter.GetUserControlView());
                _currencyUcPresenter.SetStyleDropDownList();
                _currencyUcPresenter.SetCategoryValues();
                _accountView.AddUserControl(_currencyUcPresenter.GetUserControlView());
                _accountView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
                _accountView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());
            }

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
            _currencyUcPresenter.CategoryChanged += CurrencyUcPresenterOnCategoryChanged;
        }

        private void CurrencyUcPresenterOnCategoryChanged(long id)
        {
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
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
            }


            _accountView.CloseView();
        }

        public AccountDto AccountDto { get; set; }

        public IAccountView GetView()
        {
            return _accountView;
        }
    }
}