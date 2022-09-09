﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Main;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Winforms.UI.UserControls.Main
{
    public partial class AllTransactionUCView : UserControl, IAllTransactionUCView
    {
        public AllTransactionUCView()
        {
            InitializeComponent();
        }

        private void DataGridTransactionUserControl_Load(object sender, System.EventArgs e)
        {
            dataGridViewTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewTransaction_SelectionChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show("");
        }

        public void SetData(List<TransactionExtendedDto> allTransactionsDtos)
        {
            dataGridViewTransaction.AutoGenerateColumns = false;
            dataGridViewTransaction.DataSource = new BindingList<TransactionExtendedDto>(allTransactionsDtos);
        }

        public void ClearData()
        {
            dataGridViewTransaction.Rows.Clear();
        }
    }
}