using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls
{
    public partial class SelectTypeTransactionUserControl : UserControl
    {
        public SelectTypeTransactionUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Вызывается когда пользователь выбирает тип транзакции")]
        public EventHandler TypeOperationSelectedIndexChanged;

        private void typeOperationsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.TypeOperationSelectedIndexChanged != null)
            {
                this.TypeOperationSelectedIndexChanged(this, e);
            }
        }
    }
}
