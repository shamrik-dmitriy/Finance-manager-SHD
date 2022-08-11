﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl
{
    public interface ITypeTransactionUserControlView
    {
        event Action LoadUserControlView;
        
        event Action LoadUserControl;
        void LoadTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction);
    }
}