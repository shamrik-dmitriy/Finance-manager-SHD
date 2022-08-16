using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class AccountPresenter : IAccountPresenter
    {
        private readonly IAccountView _accountView;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly ILabelTextboxUcPresenter _labelTextboxUcPresenter;
        private readonly ICategoryUCPresenter _categoryAccountUcPresenter;
        private readonly ICategoryUCPresenter _categoryCurrencyUcPresenter;
        private readonly ICheckboxUCPresenter _checkboxUcPresenter;
        private readonly IAddCancelButtonsUCPresenter _addCancelButtonsUcPresenter;

        public AccountPresenter(
            IAccountView accountView,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            ILabelTextboxUcPresenter labelTextboxUcPresenter,
            ICategoryUCPresenter categoryAccountUcPresenter,
            ICategoryUCPresenter categoryCurrencyUcPresenter,
            ICheckboxUCPresenter checkboxUcPresenter,
            IAddCancelButtonsUCPresenter addCancelButtonsUcPresenter)
        {
            _accountView = accountView;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _labelTextboxUcPresenter = labelTextboxUcPresenter;
            _categoryAccountUcPresenter = categoryAccountUcPresenter;
            _categoryCurrencyUcPresenter = categoryCurrencyUcPresenter;
            _checkboxUcPresenter = checkboxUcPresenter;
            _addCancelButtonsUcPresenter = addCancelButtonsUcPresenter;

            _accountView.OnLoadView += AccountViewOnOnLoadView;
        }

        private void AccountViewOnOnLoadView()
        {
            _labelTextboxUcPresenter.SetText("Начальная сумма");
            _accountView.AddUserControl(_nameUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_labelTextboxUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_categoryAccountUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_categoryCurrencyUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_checkboxUcPresenter.GetUserControlView());
            _accountView.AddUserControl(_addCancelButtonsUcPresenter.GetUserControlView());
        }

        public IAccountView GetView()
        {
            return _accountView;
        }
    }
}