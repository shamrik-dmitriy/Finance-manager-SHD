using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfAdditionalView
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
