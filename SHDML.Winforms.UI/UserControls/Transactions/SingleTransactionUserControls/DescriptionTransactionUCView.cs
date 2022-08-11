using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class DescriptionTransactionUCView : UserControl, IDescriptionTransactionUCView
    {
        public DescriptionTransactionUCView()
        {
            InitializeComponent();
        }

        private void textBoxDescriptionTransaction_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
