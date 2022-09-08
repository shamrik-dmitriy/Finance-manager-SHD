﻿using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
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
