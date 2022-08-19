using System;
using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IMainView : IView
    {
        event Action AddTransaction;
        event Action AddAccount;

        void SetAccountsData(IEnumerable<AccountDto> accountDtos);
    }
}