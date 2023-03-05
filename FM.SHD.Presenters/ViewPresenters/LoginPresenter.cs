using System;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Services.UserServices;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Label;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class LoginPresenter : BaseLoginPresenter
    {
        #region Private member variable

        private readonly ILoginBaseView _baseView;
        private readonly IUsersServices _usersServices;
        private readonly ILabelTextboxUcPresenter _loginPresenter;
        private readonly ILabelTextboxUcPresenter _passwordPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        #endregion

        #region Constructor / Destructor

        public LoginPresenter(ILoginBaseView baseView,
            IUsersServices usersServices,
            ILabelTextboxUcPresenter loginPresenter,
            ILabelTextboxUcPresenter passwordPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter) : base(baseView)
        {
            _baseView = baseView;
            _usersServices = usersServices;
            _loginPresenter = loginPresenter;
            _passwordPresenter = passwordPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;

            _baseView.OnLoadView += LoginBaseViewOnOnLoadBaseView;
        }

        #endregion

        #region Public methods
        
        public override void Run(IdentityDto transactionDto)
        {
            _baseView.Show();
        }

        public override void Run(string title, IdentityDto transactionDto = default(IdentityDto))
        {
            _baseView.SetTitle(title);
            _baseView.Show();
        }

        #endregion

        #region Private methods

        private void LoginBaseViewOnOnLoadBaseView()
        {
            _loginPresenter.SetText("Логин:");
            _baseView.AddUserControl(_loginPresenter.GetUserControlView());
            _passwordPresenter.SetText("Пароль:");
            _baseView.AddUserControl(_passwordPresenter.GetUserControlView());
            _continueCancelButtonsUcPresenter.SetTextButtonContinue("Войти");
            _continueCancelButtonsUcPresenter.SetTextButtonCancel("Выйти");
            _baseView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}