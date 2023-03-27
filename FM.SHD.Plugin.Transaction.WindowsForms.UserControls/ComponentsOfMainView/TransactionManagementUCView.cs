using System;
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

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction?.Invoke();
        }

        public event Action AddTransaction;
        public event Action Search;
        public event Action AddReceipt;

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            AddReceipt?.Invoke();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search?.Invoke();
        }
    }
}