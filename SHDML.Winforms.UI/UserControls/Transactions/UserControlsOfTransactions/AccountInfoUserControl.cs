using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls
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

        public AccountInfoUserControl()
        {
            InitializeComponent();
        }
    }
}
