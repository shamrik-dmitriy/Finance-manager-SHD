using FM.SHD.Presenters.IntrefacesViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Services.UserServices;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly IUsersServices _usersServices;
        private readonly ILabelTextboxUcPresenter _loginPresenter;
        private readonly ILabelTextboxUcPresenter _passwordPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        public LoginPresenter(
            ILoginView loginView, 
            IUsersServices usersServices,
            ILabelTextboxUcPresenter loginPresenter,
            ILabelTextboxUcPresenter passwordPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter)
        {
            _loginView = loginView;
            _usersServices = usersServices;
            _loginPresenter = loginPresenter;
            _passwordPresenter = passwordPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;

            _loginView.OnLoadView += LoginViewOnOnLoadView;
        }

        private void LoginViewOnOnLoadView()
        {
            _loginPresenter.SetText("Логин:");
            _loginView.AddUserControl(_loginPresenter.GetUserControlView());
            _passwordPresenter.SetText("Пароль:");
            _loginView.AddUserControl(_passwordPresenter.GetUserControlView());
            _continueCancelButtonsUcPresenter.SetTextButtonContinue("Войти");
            _continueCancelButtonsUcPresenter.SetTextButtonCancel("Выйти");
            _loginView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());
                
            _continueCancelButtonsUcPresenter.Continue+= ContinueCancelButtonsUcPresenterOnContinue;
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
        {
            throw new NotImplementedException();
        }

        public ILoginView GetView()
        {
            return _loginView;
        }
    }
}
