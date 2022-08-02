using System;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ISingleTransactionView : IView
    {
        public event EventHandler Add;

        SingleTransactionDTO GetTransactionInfo();
    }
}