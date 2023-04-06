using System;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Plugin.Categories.WindowsForms.Views
{
    public partial class CategoryManagementView : Form, ICategoryManagementView
    {
        #region Public events

        public event Action OnLoadView;

        #endregion

        private string Title
        {
            get => Text;
            set => Text = value;
        }

        private string TitleDefault { get; set; }

        #region Private member variables

        private readonly EventAggregator _eventAggregator;

        #endregion

        #region Constructor

        public CategoryManagementView()
        {
            InitializeComponent();
        }

        public CategoryManagementView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public CategoryManagementView(string typeTransactionOperations, EventAggregator eventAggregator) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Public methods

        public void SetTitle(string title)
        {
            Title = title;
            TitleDefault = title;
        }

        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            flowLayoutPanelCategory.Controls.Add(userControl);
        }

        public void AddHorizontalLine()
        {
            throw new NotImplementedException();
        }
        
        public bool ShowMessageDelete(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes;
        }

        #endregion

        #region Private methods

        private void ActionChangeTextBoxName(OnChangeNameTextApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }
        
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Unsubscribe<OnChangeNameTextApplicationEvent>(
                ActionChangeTextBoxName);
        }

        #endregion
    }
}