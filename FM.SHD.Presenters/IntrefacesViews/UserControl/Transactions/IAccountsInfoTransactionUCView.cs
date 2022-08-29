using System;
using System.Collections.Generic;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface IAccountsInfoTransactionUCView : IUserControlView
    {
        void SetAccounts(IEnumerable<AccountDto> getAll);
        event Action OnLoadUserControlView;
        void AddDate(IDateTransactionUCView getUserControlView);
        void AddAccountInfo(ICategoryUCView userControlView);
        void AddSumm(ISumTransactionUCView getUserControlView);
    }
}