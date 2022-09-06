using System;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.NewViews;

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

        /*void IView.ShowDialog()
        {
            base.ShowDialog();
        }*/

        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            flowLayoutPanel1.Controls.Add(userControl);
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