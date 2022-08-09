using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class SelectCategoryUserControl : UserControl
    {
        public string CategoryName { get => comboBoxCategoryName.Text; set => comboBoxCategoryName.Text = value; }
        public SelectCategoryUserControl()
        {
            InitializeComponent();
        }
    }
}
