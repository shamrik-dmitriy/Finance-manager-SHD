using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Dtos.UIDto;

namespace FM.SHD.Presenters.IntrefacesViews.Views
{
    public interface IMainBaseView : IBaseView
    {
        event Action AddingAccount;
        event Action<string> OpeningDataFile;
        event Action<string> CreatingDataFile;

        void AddAccountsSummaryUserControl(IUserControlView userControlView);
        void SetAccountsData(IEnumerable<AccountDto> accountDtos);
        void SetViewOnActiveUI();
        void AddElementInRecentOpenItems(List<RecentOpenFilesDto> recentOpenFiles);
        void SetViewOnUnActiveUI();
        void SetVisibleUserLoginInfo(bool isVisible);
        void ClearAccountsSummaryUserControls();

        void AddTab(TabPage tabPage);
    }
}