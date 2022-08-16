using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class IdentityUCView : UserControl, IIdentityUCView
    {
        public string FamilyMemberName { get => comboBoxFamilyMemberName.Text; set => comboBoxFamilyMemberName.Text = value; }
        
        public IdentityUCView()
        {
            InitializeComponent();
        }
    }
}
