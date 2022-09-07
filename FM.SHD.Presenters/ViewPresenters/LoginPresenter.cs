using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Services.UserServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class LoginPresenter : BaseLoginPresenter
    {
        #region Private member variable

        private readonly ILoginView _view;
        private readonly IUsersServices _usersServices;
        private readonly ILabelTextboxUcPresenter _loginPresenter;
        private readonly ILabelTextboxUcPresenter _passwordPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        #endregion

        #region Constructor / Destructor

        public LoginPresenter(ILoginView view,
            IUsersServices usersServices,
            ILabelTextboxUcPresenter loginPresenter,
            ILabelTextboxUcPresenter passwordPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter) : base(view)
        {
            _view = view;
            _usersServices = usersServices;
            _loginPresenter = loginPresenter;
            _passwordPresenter = passwordPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;

            _view.OnLoadView += LoginViewOnOnLoadView;
        }

        #endregion

        #region Public methods

        public override void SetTitle(string title)
        {
            _view.SetTitle(title);
        }

        public override void Run(IdentityDto accountDto)
        {
            _view.Show();
        }

        #endregion

        #region Private methods

        private void LoginViewOnOnLoadView()
        {
            _loginPresenter.SetText("Логин:");
            _view.AddUserControl(_loginPresenter.GetUserControlView());
            _passwordPresenter.SetText("Пароль:");
            _view.AddUserControl(_passwordPresenter.GetUserControlView());
            _continueCancelButtonsUcPresenter.SetTextButtonContinue("Войти");
            _continueCancelButtonsUcPresenter.SetTextButtonCancel("Выйти");
            _view.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}