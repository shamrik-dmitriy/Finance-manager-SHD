using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Winforms.UI.UserControls.Common
{
    public partial class CategoryUCView : UserControl, ICategoryUCView
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

        public event Action OnLoadUserControlView;
        public event Action<long> SelectedIndexChanged;

        public long? GetCategoryId()
        {
            return (long?)categoryComboBox.SelectedValue;
        }

        public BaseDto GetCategoryDto()
        {
            foreach (var item in categoryComboBox.Items)
            {
                if (((BaseDto)item).Id == (long)categoryComboBox.SelectedValue)
                {
                    return (BaseDto)item;
                }
            }

            return null;
        }

        private void CategoryUCView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
        }

        #region Label actions

        public void SetLabelText(string text)
        {
            label.Text = text;
        }

        #endregion

        #region Combobox action

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (sender is not ComboBox combobox) return;
            var id = (long)combobox.SelectedValue;
            SelectedIndexChanged?.Invoke(id);
        }

        private void comboBoxCategoryName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var combobox = (ComboBox)sender;
            if (categoryComboBox.FindString(combobox.Text) == -1)
                SetValue(0);
        }

        public void SetDataSource(IEnumerable<BaseDto> data)
        {
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DataSource = data.ToList();
        }

        private void SetValue(int index)
        {
            categoryComboBox.SelectedIndex = index;
        }

        #endregion

        #region UI actions

        public void SetVisible(bool isVisible)
        {
            Visible = isVisible;
        }

        public void SetStyleDropDown()
        {
            SetDropDownStyle(ComboBoxStyle.DropDown);
        }

        public void SetCategoryId(long? id)
        {
            if (id != null)
            {
                SetValue(categoryComboBox.FindId<BaseDto>(id));
            }
            Refresh();
        }

        public void SetStyleDropDownList()
        {
            SetDropDownStyle(ComboBoxStyle.DropDownList);
        }

        private void SetDropDownStyle(ComboBoxStyle comboBoxStyle)
        {
            categoryComboBox.DropDownStyle = comboBoxStyle;
        }

        #endregion
    }
}