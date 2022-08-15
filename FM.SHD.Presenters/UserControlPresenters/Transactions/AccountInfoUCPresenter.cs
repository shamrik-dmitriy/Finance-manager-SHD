using System;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountInfoUCPresenter : IAccountInfoUCPresenter
    {
        private readonly IAccountServices _accountServices;
        private readonly IAccountInfoUCView _accountInfoUcView;

        public AccountInfoUCPresenter(IAccountInfoUCView accountInfoUCView, IAccountServices accountServices)
        {
            _accountInfoUcView = accountInfoUCView;
            _accountServices = accountServices;
            
            _accountInfoUcView.OnLoadUserControlView += AccountInfoUcViewOnOnLoadUserControlView;
        }

        private void AccountInfoUcViewOnOnLoadUserControlView()
        {
            _accountInfoUcView.SetAccounts(_accountServices.GetAll());
        }

        public IAccountInfoUCView GetUserControlView()
        {
            return _accountInfoUcView;
        }

        [Obsolete("Возможно, стоит использовать евент агрегатор а не прокидывать события так")]
        public void SetText(string text)
        {
            _accountInfoUcView.SetText(text);
        }
        
        [Obsolete("Возможно, стоит использовать евент агрегатор а не прокидывать события так")]
        public void SetVisible(bool visible)
        {
            _accountInfoUcView.SetVisible(visible);
        }
    }
}