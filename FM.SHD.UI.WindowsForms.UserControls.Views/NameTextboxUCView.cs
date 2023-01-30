﻿using System;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Views
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
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