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
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class NameTransactionUCView : UserControl, INameTransactionUCView
    {
        private readonly EventAggregator _eventAggregator;

        public NameTransactionUCView()
        {
            InitializeComponent();
        }

        public NameTransactionUCView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        private void textBoxTransactionName_TextChanged(object sender, EventArgs e)
        {
            _eventAggregator.Publish(new OnChangeNameTransactionTextApplicationEvent() { Text = textBoxTransactionName.Text });
        }
    }
}