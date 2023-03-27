using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.Events;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfAdditionalView
{
    public partial class TypeTransactionUCView : UserControl, ITypeTransactionUCView
    {
        private readonly EventAggregator _eventAggregator;
        public event Action OnLoadUserControlView;

        public TypeTransactionUCView()
        {
            InitializeComponent();
        }

        public TypeTransactionUCView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        [Browsable(true)] [Category("Action")] [Description("Вызывается когда пользователь выбирает тип транзакции")]
        public EventHandler TypeOperationSelectedIndexChanged;

        public int Transaction
        {
            get => typeOperationsCombobox.SelectedIndex;
            set => typeOperationsCombobox.SelectedIndex = value;
        }

        private void typeOperationsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _eventAggregator.Publish(new OnSelectedTypeOfTransactionApplicationEvent()
                { TypeOfTransaction = ((ComboBox)sender).SelectedIndex });
        }

        #region UI actions

        public void SetTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction)
        {
            typeOperationsCombobox.Items.AddRange(allTypesOfTransaction.Select(x => x.Name).ToArray());
        }

        public void SetTransactionType(int index)
        {
            typeOperationsCombobox.SelectedIndex = index;
        }

        #endregion

        private void TypeTransactionUserControlView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
            SetTransactionType(0);
        }
    }
}