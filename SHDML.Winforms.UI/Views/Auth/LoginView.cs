using FM.SHD.Presenters.IntrefacesViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace SHDML.Winforms.UI.Views.Auth
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

        public void AddUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            flowLayoutPanel.Controls.Add(userControl);
        }

        public void ShowDialog(string title)
        {
            base.Text = title;
            ShowDialog();
        }

        void IView.ShowDialog()
        {
            ShowDialog();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
        }
    }
}