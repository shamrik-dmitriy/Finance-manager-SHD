
namespace SHDML.Winforms.UI.UserControls.Wallet
{
    partial class UserControlCategoryAccount
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelCategorySum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCategoryName.AutoEllipsis = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategoryName.Location = new System.Drawing.Point(3, 3);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(3);
            this.labelCategoryName.MaximumSize = new System.Drawing.Size(150, 150);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(150, 40);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Полуфабрикаты по пробуй приготовь\r\nПолуфабрикаты по пробуй приготовь\r\nПолуфабрика" +
    "ты по пробуй приготовь\r\n\r\n";
            this.labelCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategorySum
            // 
            this.labelCategorySum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCategorySum.AutoEllipsis = true;
            this.labelCategorySum.AutoSize = true;
            this.labelCategorySum.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategorySum.ForeColor = System.Drawing.Color.Green;
            this.labelCategorySum.Location = new System.Drawing.Point(161, 3);
            this.labelCategorySum.Name = "labelCategorySum";
            this.labelCategorySum.Size = new System.Drawing.Size(146, 21);
            this.labelCategorySum.TabIndex = 1;
            this.labelCategorySum.Text = "+200000000.00P";
            this.labelCategorySum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.labelCategorySum);
            this.panel1.Controls.Add(this.labelCategoryName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(310, 100);
            this.panel1.MinimumSize = new System.Drawing.Size(310, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 46);
            this.panel1.TabIndex = 2;
            // 
            // UserControlCategoryAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(310, 100);
            this.MinimumSize = new System.Drawing.Size(310, 28);
            this.Name = "UserControlCategoryAccount";
            this.Size = new System.Drawing.Size(310, 49);
            this.Load += new System.EventHandler(this.CategoryAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelCategorySum;
        public System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Panel panel1;
    }
}
