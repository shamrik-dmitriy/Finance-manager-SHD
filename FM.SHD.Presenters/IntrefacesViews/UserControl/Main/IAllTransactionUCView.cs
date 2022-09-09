using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Main
{
    public interface IAllTransactionUCView : IUserControlView
    {
        void SetData(List<TransactionExtendedDto> allTransactionsDtos);
        void ClearData();
    }
}