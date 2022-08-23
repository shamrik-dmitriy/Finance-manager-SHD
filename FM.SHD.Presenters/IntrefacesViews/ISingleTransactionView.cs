using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ISingleTransactionView : IView
    {
        event Action OnLoadView;
        event EventHandler Add;
        event Action<int> OnChangeTypeTransaction;

        void AddUserControl(IUserControlView userControlView);
        SingleTransactionDto GetTransactionInfo();
        void AddHorizontalLine();
    }
}