using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface IAccountInfoUCView
    {
        event Action OnLoadUserControlView;
        
        void SetText(string text);
        void SetVisible(bool visible);
        void SetAccounts(IEnumerable<AccountDto> allAccounts);
    }
}