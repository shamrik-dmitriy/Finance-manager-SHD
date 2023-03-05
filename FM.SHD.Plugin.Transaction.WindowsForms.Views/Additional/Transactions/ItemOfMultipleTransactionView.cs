using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Additional.Transactions
{
    public partial class ItemOfMultipleTransaction : UserControl
    {
        public ItemOfMultipleTransaction()
        {
            InitializeComponent();
        }
        public decimal Price
        {
            get
            {
                return Convert.ToDecimal(pricelProductName.Text.Trim(' ', '₽'));
            }
        }
        public ItemOfMultipleTransaction(string productName, string price) : this()
        {
            productNameLabel.Text = productName;
            pricelProductName.Text = price + " ₽";
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Вызывается когда пользователь удаляет транзакцию из чека")]
        public EventHandler DeleteItemFromReceipt;

        [Browsable(true)]
        [Category("Action")]
        [Description("Вызывается когда пользователь изменяет транзакцию из чека")]
        public EventHandler ChangeItemFromReceipt;

        private void deleteTransactionButton_Click(object sender, EventArgs e)
        {
            if (this.DeleteItemFromReceipt != null)
            {
                this.DeleteItemFromReceipt(this, e);
            }
        }

        private void changeItemInfo_click(object sender, EventArgs e)
        {
            if (this.ChangeItemFromReceipt != null)
            {
                this.ChangeItemFromReceipt(this, e);
            }
        }
    }
}
