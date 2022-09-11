using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.Views;

namespace FM.SHD.Winforms.UI.Views.Account
{
    public partial class AccountView : Form, IAccountView
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


        public AccountView()
        {
            InitializeComponent();
        }

        public AccountView(EventAggregator eventAggregator) : this()
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
            _eventAggregator.Subscribe<OnChangeNameTransactionTextApplicationEvent>(ActionChangeTextBoxNameTransaction);
        }

        private void ActionChangeTextBoxNameTransaction(OnChangeNameTransactionTextApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AccountView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosingView?.Invoke();
        }
    }
}