using System;
using System.Collections.Generic;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Main
{
    public interface IAllTransactionUCView : IUserControlView
    {
        event Action<TransactionExtendedDto> UpdateTransaction;
        
        void SetData(List<TransactionExtendedDto> allTransactionsDtos);
        void SetData(TransactionExtendedDto transactionsDtos);
        void ClearData();
    }
}