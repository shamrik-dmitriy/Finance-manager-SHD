using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews;
using SHDML.Winforms.UI.Transactions;

namespace SHDML.Winforms.UI
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler AddTransaction;

        private readonly ILogger _logger;

        public MainView(ILogger<MainView> logger)
        {
            InitializeComponent();
            _logger = logger;
            _logger.LogTrace($"Приложение запущено {DateTime.Now}");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (!_authUcView.IsSigned)
            {
                _authUcView.IsSigned = true;
                _authUcView.UserName.Text = "Hello!, you signed in!";
                buttonSign.Text = "Выйти";
            }
            else
            {
                _authUcView.IsSigned = false;
                buttonSign.Text = "Войти";
                _authUcView.UserName.Text = "Пользователь не задан";
            }

            _categoryAccount1.Update();
            _categoryAccount1.Refresh();
        }

        private void buttonTransactionReview_Click(object sender, EventArgs e)
        {
            splitContainerMainDesktop.Panel2.Controls.Add(new Label() { Text = "Yep!" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction?.Invoke(sender, e);
        }

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            new MultipleTransactionView("Добавить группу транзакций (чек)").ShowDialog();
        }

        private void seeCategoriesButton_Click(object sender, EventArgs e)
        {
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public void ShowDialog(string title)
        {
            base.Text = title;
            base.ShowDialog();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }
    }
}