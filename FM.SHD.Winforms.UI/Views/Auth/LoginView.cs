using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.Views;

namespace FM.SHD.Winforms.UI.Views.Auth
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public event Action OnLoadView;

        public void CloseView()
        {
            Close();
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            flowLayoutPanel.Controls.Add(userControl);
        }

        public void AddHorizontalLine()
        {
            throw new NotImplementedException();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
        }
    }
}