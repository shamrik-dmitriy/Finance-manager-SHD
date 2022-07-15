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
            if (!userControlAuth1.IsSigned)
            {
                userControlAuth1.IsSigned = true;
                userControlAuth1.UserName.Text = "Hello!, you signed in!";
                buttonSign.Text = "Выйти";
            }
            else
            {
                userControlAuth1.IsSigned = false;
                buttonSign.Text = "Войти";
                userControlAuth1.UserName.Text = "Пользователь не задан";
            }
        }

        private void buttonTransactionReview_Click(object sender, EventArgs e)
        {
            splitContainerMainDesktop.Panel2.Controls.Add(new Label() { Text="Yep!"});
        }
    }
}
