using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfMainView
{
    public partial class TransactionManagementUCView : UserControl, ITransactionManagementUCView
    {
        public TransactionManagementUCView()
        {
            InitializeComponent();
        }
    }
}