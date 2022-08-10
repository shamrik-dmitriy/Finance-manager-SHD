using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class TypeTransactionUserControlView : UserControl, ITypeTransactionUserControlView
    {
        private readonly EventAggregator _eventAggregator;
        public event Action LoadUserControlView;

        public TypeTransactionUserControlView()
        {
            InitializeComponent();
        }

        public TypeTransactionUserControlView(EventAggregator eventAggregator) : this()
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
            _eventAggregator.Publish(new SelectedTypeOfTransactionApplicationEvent() { TypeOfTransaction = 0 });
            // TypeOperationSelectedIndexChanged?.Invoke(this, e);
        }

        public event Action LoadUserControl;

        public void LoadTransactionTypes(IEnumerable<TypeTransactionDto> allTypesOfTransaction)
        {
            throw new NotImplementedException();
        }

        #region UI actions

        public void SetTransactionType(int index)
        {
            typeOperationsCombobox.SelectedIndex = index;
        }

        #endregion

        private void TypeTransactionUserControlView_Load(object sender, EventArgs e)
        {
            LoadUserControlView?.Invoke();
        }
    }
}