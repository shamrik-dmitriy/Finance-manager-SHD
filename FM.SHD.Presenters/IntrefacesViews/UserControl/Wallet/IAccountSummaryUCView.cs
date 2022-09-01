using System;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet
{
    public interface IAccountSummaryUCView : IUserControlView
    {
        event Action<AccountDto> UpdateAccount;

        void SetData(AccountDto accountDto);
    }
}