using System.ComponentModel;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class AccountInfoUCView : UserControl
    {
        [Browsable(true)]
        [Category("Property")]
        [Description("Изменяет текст лейбла рядом с элементов выбора")]
        public string LabelOfTypeOperation
        {
            get { return accountLabel.Text; }
            set { accountLabel.Text = value; }
        }

        public string Name { get => accountComboBox.Text; set => accountComboBox.Text = value; }

        public AccountInfoUCView()
        {
            InitializeComponent();
        }
    }
}
