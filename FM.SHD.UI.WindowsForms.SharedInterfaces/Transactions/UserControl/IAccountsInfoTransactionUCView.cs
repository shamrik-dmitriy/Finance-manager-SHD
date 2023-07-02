using System;
using System.Collections.Generic;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface IAccountsInfoTransactionUCView : IUserControlView
    {
        void SetAccounts(IEnumerable<AccountDto> getAll);
        event Action OnLoadUserControlView;
        void AddDate(IDateTransactionUCView getUserControlView);
        void AddAccountInfo(ICategoryComboboxUCView userControlView);
        void AddSumm(ISumTransactionUCView getUserControlView);
    }
}