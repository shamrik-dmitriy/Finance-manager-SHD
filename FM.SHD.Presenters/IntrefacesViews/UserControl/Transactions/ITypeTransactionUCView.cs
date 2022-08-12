using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface ITypeTransactionUCView
    {
        event Action LoadUserControlView;
        
        void SetTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction);
    }
}
