using System;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet
{
    public interface IAccountSummaryUCView : IUserControlView
    {
        event Action<long> UpdateAccount;

        void SetData(AccountDto accountDto);
    }
}