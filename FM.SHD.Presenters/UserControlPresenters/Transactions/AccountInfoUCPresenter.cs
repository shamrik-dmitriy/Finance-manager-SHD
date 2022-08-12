using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class AccountInfoUCPresenter : IAccountInfoUCPresenter
    {
        private readonly IAccountInfoUCView _accountInfoUcView;

        public AccountInfoUCPresenter(IAccountInfoUCView accountInfoUCView)
        {
            _accountInfoUcView = accountInfoUCView;
        }
        
        public IAccountInfoUCView GetUserControlView()
        {
            return _accountInfoUcView;
        }
    }
}