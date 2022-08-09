using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class SelectFamilyMemberUserControl : UserControl
    {
        public string FamilyMemberName { get => comboBoxFamilyMemberName.Text; set => comboBoxFamilyMemberName.Text = value; }
        
        public SelectFamilyMemberUserControl()
        {
            InitializeComponent();
        }
    }
}
