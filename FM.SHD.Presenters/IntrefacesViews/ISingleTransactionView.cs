using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ISingleTransactionView : IView
    {
        event Action OnLoadEventrsss;
        event EventHandler Add;
        event Action<int> OnChangeTypeTransaction;

        void SetVisibleCreditAccout(bool isVisible);
        SingleTransactionDTO GetTransactionInfo();
        void AddTypeTransactionUserControl(ITypeTransactionUCView getUcView);
        void AddNameTransactionUserControl(INameTransactionUCView getUcView);
        void AddDescriptionTransactionUserControl(IDescriptionTransactionUCView getUcView);
        void AddAccountsInfoTransactionUserControl(IAccountsInfoTransactionUCView getUcView);
        void AddHorizontalLine();
    }
}