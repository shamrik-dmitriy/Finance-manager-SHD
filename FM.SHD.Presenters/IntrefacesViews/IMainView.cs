using System;
using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos.UIDto;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IMainView : IView
    {
        event Action AddTransaction;
        event Action AddAccount;
        event Action<string> OpenDataFile;

        void SetVisibleRecentOpenMenuItem(bool isVisible);
       void AddAccountsSummaryUserControl(IUserControlView userControlView);
        void SetAccountsData(IEnumerable<AccountDto> accountDtos);
        void SetViewOnUnCompleteLoadData();
        void AddElementInRecentOpenItems(List<RecentOpenFilesDto> recentOpenFiles);
    }
}