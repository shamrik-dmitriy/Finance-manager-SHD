using System;
using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IMainView : IView
    {
        event Action AddTransaction;
        event Action AddAccount;

        void AddAccountsSummaryUserControl(IUserControlView userControlView);
        void SetAccountsData(IEnumerable<AccountDto> accountDtos);
    }
}