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

        SingleTransactionDTO GetTransactionInfo();
        void AddTypeTransactionUserControl(ITypeTransactionUCView getUcView);
        void AddNameTransactionUserControl(INameTextboxUCView getUcView);
        void AddDescriptionTransactionUserControl(IDescriptionTextboxUCView getUcView);
        void AddAccountsInfoTransactionUserControl(IAccountsInfoTransactionUCView getUcView);
        void AddCategoryTransactionUserControl(ICategoryTransactionUCView getUcView);
        void AddContrAgentUserControl(IContrAgentUCView getUcView);
        void AddIdentityUCView(IIdentityUCView ucView);
        void AddAddCancelButtonsUserControl(IAddCancelButtonsUCView ucView);
        void AddHorizontalLine();
    }
}