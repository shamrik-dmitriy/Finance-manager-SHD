using System;
using System.Collections.Generic;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface ITypeTransactionUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction);
    }
}
