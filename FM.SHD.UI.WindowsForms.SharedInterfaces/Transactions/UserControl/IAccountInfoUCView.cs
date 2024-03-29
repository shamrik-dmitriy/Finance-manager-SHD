using System;
using System.Collections.Generic;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface IAccountInfoUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetText(string text);
        void SetVisible(bool visible);
        void SetAccounts(IEnumerable<AccountDto> allAccounts);
    }
}