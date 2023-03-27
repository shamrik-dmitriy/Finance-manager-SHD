using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface ITransactionManagementUCView : IUserControlView
    {
        event Action AddTransaction;
        event Action Search;
        event Action AddReceipt;
    }
}
