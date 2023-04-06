﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views
{
    public partial class TransactionManagementView : Form, ITransactionManagementView
    {
        #region Private member variables

        private readonly EventAggregator _eventAggregator;

        #endregion

        #region Public events

        public event Action OnLoadView;

        #endregion

        #region Private properties

        private string Title
        {
            get => Text;
            set => Text = value;
        }

        private string TitleDefault { get; set; }

        #endregion

        #region Constructors

        public TransactionManagementView()
        {
            InitializeComponent();
        }

        public TransactionManagementView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public TransactionManagementView(string typeTransactionOperations, EventAggregator eventAggregator) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Private methods

        private void ActionChangeTextBoxName(OnChangeNameTextApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
            _eventAggregator.Subscribe<OnChangeNameTextApplicationEvent>(ActionChangeTextBoxName);
           AcceptButton = (Button)Controls.Find("continueButton", true)[0];
            CancelButton = (Button)Controls.Find("cancelButton", true)[0];
        }

        #endregion

        public new void Show()
        {
            base.ShowDialog();
        }

        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(userControl);
        }

        public void AddHorizontalLine()
        {
            singleTransactionDesktopflowLayoutPanel.Controls.Add(new Label()
                { BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top, Size = new Size(359, 2) });
        }

        public void SetTitle(string title)
        {
            Title = title;
            TitleDefault = title;
        }

        public void Clear()
        {
            singleTransactionDesktopflowLayoutPanel.Controls.Clear();
        }

        public bool ShowMessageDelete(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Unsubscribe<OnChangeNameTextApplicationEvent>(
                ActionChangeTextBoxName);
        }
    }
}