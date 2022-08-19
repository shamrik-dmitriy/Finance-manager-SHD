using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface ITypeTransactionUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction);
        int GetTypeTransaction();
    }
}
