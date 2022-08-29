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
        private readonly ICategoryUCPresenter<AccountServices> _accountUcPresenter;
        private readonly ICategoryUCPresenter<CurrencyServices> _currencyUcPresenter;
        private readonly ICheckboxUCPresenter _checkboxUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        public AccountPresenter(
            IAccountServices accountServices,
            IAccountView accountView,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            ILabelTextboxUcPresenter labelTextboxUcPresenter,
            ICategoryUCPresenter<AccountServices>  accountUcPresenter,
            ICategoryUCPresenter<CurrencyServices>  currencyUcPresenter,
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
            _accountView.AddUserControl(_nameUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
            _labelTextboxUcPresenter.SetText("Начальная сумма");
            _accountView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
            _accountUcPresenter.SetText("Категория счёта");
            _accountView.AddUserControl(_accountUcPresenter.GetUserControlView());
            _currencyUcPresenter.SetStyleDropDownList();
            _currencyUcPresenter.SetText("Валюта");
            _accountView.AddUserControl(_currencyUcPresenter.GetUserControlView());
            _checkboxUcPresenter.SetText("Закрытый счёт");
            _accountView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
            _currencyUcPresenter.CategoryChanged += CurrencyUcPresenterOnCategoryChanged;

            //_categoryAccountUcPresenter.SetCategoryValues();
        }

        private void CurrencyUcPresenterOnCategoryChanged(long id)
        {
            
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
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
            _accountView.CloseView();
        }

        public IAccountView GetView()
        {
            return _accountView;
        }
    }
}