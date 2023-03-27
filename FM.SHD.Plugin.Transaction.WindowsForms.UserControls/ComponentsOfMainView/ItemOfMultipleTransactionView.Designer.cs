namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfMainView
{
    partial class ItemOfMultipleTransaction
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pricelProductName = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.deleteTransactionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.changeItemInfo_click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pricelProductName);
            this.panel1.Controls.Add(this.productNameLabel);
            this.panel1.Location = new System.Drawing.Point(36, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 32);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.changeItemInfo_click);
            // 
            // pricelProductName
            // 
            this.pricelProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pricelProductName.AutoSize = true;
            this.pricelProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelProductName.Location = new System.Drawing.Point(220, 6);
            this.pricelProductName.Name = "pricelProductName";
            this.pricelProductName.Size = new System.Drawing.Size(62, 19);
            this.pricelProductName.TabIndex = 1;
            this.pricelProductName.Text = "125.00 Р";
            this.pricelProductName.Click += new System.EventHandler(this.changeItemInfo_click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoEllipsis = true;
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(3, 10);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(149, 15);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Молоко Лужайкино 2.5%";
            this.productNameLabel.Click += new System.EventHandler(this.changeItemInfo_click);
            // 
            // deleteTransactionButton
            // 
            this.deleteTransactionButton.AutoSize = true;
            this.deleteTransactionButton.Location = new System.Drawing.Point(324, 2);
            this.deleteTransactionButton.Name = "deleteTransactionButton";
            this.deleteTransactionButton.Size = new System.Drawing.Size(29, 32);
            this.deleteTransactionButton.TabIndex = 3;
            this.deleteTransactionButton.Text = "❌";
            this.deleteTransactionButton.UseVisualStyleBackColor = true;
            this.deleteTransactionButton.Click += new System.EventHandler(this.deleteTransactionButton_Click);
            // 
            // ItemOfMultipleTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteTransactionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(358, 38);
            this.MinimumSize = new System.Drawing.Size(358, 38);
            this.Name = "ItemOfMultipleTransaction";
            this.Size = new System.Drawing.Size(356, 36);
            this.Click += new System.EventHandler(this.changeItemInfo_click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pricelProductName;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button deleteTransactionButton;
    }
}
