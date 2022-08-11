using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class NameTransactionUserControlView : UserControl, INameTransactionUserControlView
    {
        private readonly EventAggregator _eventAggregator;

        public NameTransactionUserControlView()
        {
            InitializeComponent();
        }

        public NameTransactionUserControlView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        private void textBoxTransactionName_TextChanged(object sender, EventArgs e)
        {
            _eventAggregator.Publish(new ChangeTextBoxNameTransactionText() { Text = textBoxTransactionName.Text });
        }
    }
}