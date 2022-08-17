﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class CategoryUCView : UserControl, ICategoryTransactionUCView
    {
        public string CategoryName
        {
            get => categoryComboBox.Text;
            set => categoryComboBox.Text = value;
        }

        public CategoryUCView()
        {
            InitializeComponent();
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public CategoryUCView(string labelText) : this()
        {
            label.Text = labelText;
        }


        public void SetDataSource(IEnumerable<string> data)
        {
        }

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void comboBoxCategoryName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var combobox = (ComboBox)sender;
            if (categoryComboBox.FindString(combobox.Text) == -1)
                SetValue(0);
        }

        private void SetValue(int index)
        {
            categoryComboBox.SelectedIndex = index;
        }

        public event Action OnLoadUserControlView;

        public void SetLabelText(string text)
        {
            label.Text = text;
        }

        public (int, string) GetCategoryInfo()
        {
            return (categoryComboBox.SelectedIndex, categoryComboBox.SelectedText);
        }

        public void SetCategoryValues(IEnumerable<string> value)
        {
            categoryComboBox.Items.AddRange(value.ToArray());
        }

        private void CategoryUCView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
        }
    }
}