using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHD.Presenters.NewPresenters;
using FM.SHD.Services.AccountServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.UserControlPresenters.Wallet
{
    public class AccountSummaryUCPresenter : IAccountSummaryUCPresenter
    {
        private readonly IAccountSummaryUCView _accountSummaryUcView;
        private readonly BaseAccountPresenter _accountPresenter;
        private readonly IAccountServices _accountServices;

        public AccountSummaryUCPresenter(
            IAccountSummaryUCView accountSummaryUcView,
            BaseAccountPresenter accountPresenter,
            IAccountServices accountServices)
        {
            _accountSummaryUcView = accountSummaryUcView;
            _accountPresenter = accountPresenter;
            _accountServices = accountServices;

            _accountSummaryUcView.UpdateAccount += AccountSummaryUcViewOnUpdateAccount;
        }

        private void AccountSummaryUcViewOnUpdateAccount(AccountDto accountDto)
        {
            _accountPresenter.SetTitle("Редактирование счёта");
            _accountPresenter.Run(accountDto);
        }

        public IAccountSummaryUCView GetUserControlView()
        {
            return _accountSummaryUcView;
        }

        public IAccountSummaryUCView GetUserControlView(AccountDto accountDto)
        {
            _accountSummaryUcView.SetData(accountDto);
            return _accountSummaryUcView;
        }
    }
}