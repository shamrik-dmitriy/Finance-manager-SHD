using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.MultipleTransaction
{
    public partial class ItemOfMultipleTransaction : UserControl
    {
        public ItemOfMultipleTransaction()
        {
            InitializeComponent();
        }
        public ItemOfMultipleTransaction(string productName, string price) : this()
        {
            labelProductName.Text = productName;
            pricelProductName.Text = price + " ₽";
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Вызывается когда пользователь удаляет транзакцию из чека")]
        public EventHandler DeleteItemFromReceipt;

        private void deleteTransactionButton_Click(object sender, EventArgs e)
        {
            if (this.DeleteItemFromReceipt != null)
            {
                this.DeleteItemFromReceipt(this, e);
            }
        }
    }
}
