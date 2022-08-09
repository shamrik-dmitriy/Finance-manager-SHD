using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
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

        public int Transaction { get => typeOperationsCombobox.SelectedIndex; set => typeOperationsCombobox.SelectedIndex = value; }

        private void typeOperationsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.TypeOperationSelectedIndexChanged != null)
            {
                this.TypeOperationSelectedIndexChanged(this, e);
            }
        }
    }
}
