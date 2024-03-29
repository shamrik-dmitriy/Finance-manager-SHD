﻿

using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Winforms.UI.Views.Account
{
    public partial class AccountBaseView : Form, IAccountBaseView
    {
        #region Private member variables

        private readonly EventAggregator _eventAggregator;

        #endregion

        #region Public events

        public event Action OnLoadView;
        public event Action OnClosingView;
        public bool ShowMessageDelete(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes;
        }

        public void SetTitle(string title)
        {
            Title = title;
            TitleDefault = title;
        }

        #endregion

        private string Title
        {
            get => Text;
            set => Text = value;
        }

        private string TitleDefault { get; set; }


        public AccountBaseView()
        {
            InitializeComponent();
        }

        public AccountBaseView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public new void Show()
        {
            base.ShowDialog();
        }
        
        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            flowLayoutPanel1.Controls.Add(userControl);
        }

        public void AddHorizontalLine()
        {
            flowLayoutPanel1.Controls.Add(new Label()
                { BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top, Size = new Size(359, 2) });

        }

        public void CloseView()
        {
            Close();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
            _eventAggregator.Subscribe<OnChangeTitleViewApplicationEvent>(ActionChangeTextBoxNameTransaction);
            AcceptButton = (Button)Controls.Find("continueButton", true)[0];
            CancelButton = (Button)Controls.Find("cancelButton", true)[0];
        }

        private void ActionChangeTextBoxNameTransaction(OnChangeTitleViewApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AccountView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosingView?.Invoke();
        }
    }
}