
namespace FM.SHD.Winforms.UI.UserControls.Wallet
{
    partial class AccountSummaryUCView
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountSumLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountNameLabel.AutoEllipsis = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountNameLabel.Location = new System.Drawing.Point(3, 3);
            this.accountNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.accountNameLabel.MaximumSize = new System.Drawing.Size(150, 150);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(150, 40);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountNameLabel.Click += new System.EventHandler(this.account_Click);
            // 
            // accountSumLabel
            // 
            this.accountSumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountSumLabel.AutoEllipsis = true;
            this.accountSumLabel.AutoSize = true;
            this.accountSumLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountSumLabel.ForeColor = System.Drawing.Color.Green;
            this.accountSumLabel.Location = new System.Drawing.Point(161, 3);
            this.accountSumLabel.Name = "accountSumLabel";
            this.accountSumLabel.Size = new System.Drawing.Size(0, 21);
            this.accountSumLabel.TabIndex = 1;
            this.accountSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountSumLabel.Click += new System.EventHandler(this.account_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.accountSumLabel);
            this.panel1.Controls.Add(this.accountNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(310, 100);
            this.panel1.MinimumSize = new System.Drawing.Size(310, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 46);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.account_Click);
            // 
            // AccountSummaryUcView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(310, 100);
            this.MinimumSize = new System.Drawing.Size(310, 28);
            this.Name = "AccountSummaryUCView";
            this.Size = new System.Drawing.Size(310, 49);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label accountSumLabel;
        public System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
