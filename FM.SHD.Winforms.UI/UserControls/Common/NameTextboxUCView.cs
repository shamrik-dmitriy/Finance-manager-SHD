using System;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class NameTextboxUCView : UserControl, INameTextboxUCView
    {
        private readonly EventAggregator _eventAggregator;

        public NameTextboxUCView()
        {
            InitializeComponent();
        }

        public NameTextboxUCView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        private void textBoxTransactionName_TextChanged(object sender, EventArgs e)
        {
            _eventAggregator.Publish(new OnChangeNameTransactionTextApplicationEvent()
                { Text = textBoxTransactionName.Text });
        }

        public string GetName()
        {
            return textBoxTransactionName.Text;
        }

        public void SetName(string name)
        {
            textBoxTransactionName.Text = name;
        }
    }
}