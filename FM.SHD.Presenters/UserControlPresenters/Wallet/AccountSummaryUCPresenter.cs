using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHD.Services.AccountServices;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.UserControlPresenters.Wallet
{
    public class AccountSummaryUCPresenter : IAccountSummaryUCPresenter
    {
        private readonly IAccountSummaryUCView _accountSummaryUcView;
        private readonly IAccountPresenter _accountPresenter;
        private readonly IAccountServices _accountServices;

        public AccountSummaryUCPresenter(
            IAccountSummaryUCView accountSummaryUcView,
            IAccountPresenter accountPresenter,
            IAccountServices accountServices)
        {
            _accountSummaryUcView = accountSummaryUcView;
            _accountPresenter = accountPresenter;
            _accountServices = accountServices;

            _accountSummaryUcView.UpdateAccount += AccountSummaryUcViewOnUpdateAccount;
        }

        private void AccountSummaryUcViewOnUpdateAccount(AccountDto accountDto)
        {
            _accountPresenter.AccountDto = accountDto;
            _accountPresenter.GetView().ShowDialog("Редактирование транзакции");
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