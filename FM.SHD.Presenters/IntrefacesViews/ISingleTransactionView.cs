using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ISingleTransactionView : IView
    {
        event Action OnLoadView;
        event EventHandler Add;
        event Action<int> OnChangeTypeTransaction;

        void AddUserControl(IUserControlView userControlView);
        SingleTransactionDTO GetTransactionInfo();
        void AddHorizontalLine();
    }
}