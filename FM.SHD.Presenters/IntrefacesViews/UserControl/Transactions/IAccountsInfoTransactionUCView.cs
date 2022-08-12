using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface IAccountsInfoTransactionUCView
    {
        void SetAccounts(IEnumerable<AccountDto> getAll);
        event Action LoadUserControlView;
    }
}