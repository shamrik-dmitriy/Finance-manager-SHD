using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface ITypeTransactionUCView : IUserControlView
    {
        event Action OnLoadUserControlView;
        
        void SetTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction);
    }
}
