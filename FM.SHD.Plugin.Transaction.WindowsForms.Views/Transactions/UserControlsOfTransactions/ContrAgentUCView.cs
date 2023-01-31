using System.Windows.Forms;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions.UserControlsOfTransactions
{
    public partial class ContrAgentUCView : UserControl, IContrAgentUCView
    {
        public string ContragentName { get => comboBoxContrAgentName.Text; set => comboBoxContrAgentName.Text = value; }

        public ContrAgentUCView()
        {
            InitializeComponent();
        }
    }
}
