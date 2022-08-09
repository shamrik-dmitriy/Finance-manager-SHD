using System.ComponentModel;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class AccountInfoUserControl : UserControl
    {
        [Browsable(true)]
        [Category("Property")]
        [Description("Изменяет текст лейбла рядом с элементов выбора")]
        public string LabelOfTypeOperation
        {
            get { return infoAccountLabel.Text; }
            set { infoAccountLabel.Text = value; }
        }

        public string Name { get => debitAccountComboBox.Text; set => debitAccountComboBox.Text = value; }

        public AccountInfoUserControl()
        {
            InitializeComponent();
        }
    }
}
