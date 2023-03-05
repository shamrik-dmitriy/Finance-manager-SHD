using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet
{
    public interface IAccountSummaryUCView : IUserControlView
    {
        event Action<AccountDto> UpdateAccount;

        void SetData(AccountDto accountDto);
    }
}