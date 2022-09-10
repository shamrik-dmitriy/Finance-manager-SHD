using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Winforms.UI.Views.Transactions
{
    public partial class TransactionView : Form, ITransactionView
    {
        #region Private member variables

        private readonly EventAggregator _eventAggregator;

        #endregion

        #region Public events

        public event Action OnLoadView;
        public event EventHandler Add;
        public event Action<int> OnChangeTypeTransaction;

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

        public TransactionView()
        {
            InitializeComponent();
        }

        public TransactionView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public TransactionView(string typeTransactionOperations, EventAggregator eventAggregator) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Private methods

        private void ActionChangeTextBoxNameTransaction(OnChangeNameTransactionTextApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
            _eventAggregator.Subscribe<OnChangeNameTransactionTextApplicationEvent>(ActionChangeTextBoxNameTransaction);
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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Unsubscribe<OnChangeNameTransactionTextApplicationEvent>(
                ActionChangeTextBoxNameTransaction);
        }
    }
}