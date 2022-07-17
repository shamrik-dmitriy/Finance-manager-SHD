using SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.SingleTransaction
{
    public partial class AddSingleTransactionForm : Form
    {
        public AddSingleTransactionForm()
        {
            InitializeComponent();
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            selectTypeTransactionUserControl1.TypeOperationSelectedIndexChanged += new EventHandler(SelectTypeTransaction_SelectedIndexChanged);
        }

        protected void SelectTypeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (SelectTypeTransactionUserControl)sender;
            flowLayoutPanel2.Controls.Clear();
            switch (s.typeOperationsCombobox.SelectedIndex)
            {
                case 0:
                    {
                        flowLayoutPanel2.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
                case 1:
                    {
                        flowLayoutPanel2.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
                case 2:
                    {
                        flowLayoutPanel2.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
            }
            flowLayoutPanel2.Refresh();
            flowLayoutPanel2.Update();
        }

    }
}
