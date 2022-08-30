using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.Interfaces.UserControls.Wallet
{
    public interface IAccountSummaryUCPresenter
    {
        IAccountSummaryUCView GetUserControlView();
        IAccountSummaryUCView GetUserControlView(AccountDto accountDto);
    }
}