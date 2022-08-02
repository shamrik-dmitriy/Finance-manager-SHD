using FM.SHD.Services.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SHDML.Winforms.UI.Transactions.MultipleTransaction;
using SHDML.Winforms.UI.Transactions.SingleTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Presenters;
using FM.SHD.Presenters.IntrefacesViews;

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
            if (!userControlAuth.IsSigned)
            {
                userControlAuth.IsSigned = true;
                userControlAuth.UserName.Text = "Hello!, you signed in!";
                buttonSign.Text = "Выйти";
            }
            else
            {
                userControlAuth.IsSigned = false;
                buttonSign.Text = "Войти";
                userControlAuth.UserName.Text = "Пользователь не задан";
            }

            userControlCategoryAccount1.Update();
            userControlCategoryAccount1.Refresh();
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
            new MultipleTransactionForm("Добавить группу транзакций (чек)").ShowDialog();
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