using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class ContrAgentUCView : UserControl
    {
        public string ContragentName { get => comboBoxContrAgentName.Text; set => comboBoxContrAgentName.Text = value; }

        public ContrAgentUCView()
        {
            InitializeComponent();
        }
    }
}
