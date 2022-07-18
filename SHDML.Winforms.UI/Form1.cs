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

namespace SHDML.Winforms.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            new AddSingleTransactionForm("Добавить операцию").ShowDialog();
        }
    }
}
