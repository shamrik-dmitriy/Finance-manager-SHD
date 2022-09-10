using System;
using System.Collections.Generic;
using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Dtos.UIDto;

namespace FM.SHD.Presenters.IntrefacesViews.Views
{
    public interface IMainView : IView
    {
        event Action AddingTransaction;
        event Action AddingAccount;
        event Action<string> OpenDataFile;

        void AddAccountsSummaryUserControl(IUserControlView userControlView);
        void SetAccountsData(IEnumerable<AccountDto> accountDtos);
        void SetViewOnActiveUI();
        void AddElementInRecentOpenItems(List<RecentOpenFilesDto> recentOpenFiles);
        void SetViewOnUnActiveUI();
        void SetVisibleUserLoginInfo(bool isVisible);

        void ClearAccountsSummaryUserControls();
    }
}