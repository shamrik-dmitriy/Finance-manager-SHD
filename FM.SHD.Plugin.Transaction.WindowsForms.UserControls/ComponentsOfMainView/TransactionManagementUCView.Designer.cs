namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfMainView
{
    partial class TransactionManagementUCView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.buttonAddTransaction);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddReceipt);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.buttonSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.AutoSize = true;
            this.buttonAddTransaction.Location = new System.Drawing.Point(3, 3);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(138, 25);
            this.buttonAddTransaction.TabIndex = 0;
            this.buttonAddTransaction.Text = "Добавить транзакцию";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.AutoSize = true;
            this.buttonAddReceipt.Location = new System.Drawing.Point(147, 3);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(91, 25);
            this.buttonAddReceipt.TabIndex = 1;
            this.buttonAddReceipt.Text = "Добавить чек";
            this.buttonAddReceipt.UseVisualStyleBackColor = true;
            this.buttonAddReceipt.Click += new System.EventHandler(this.buttonAddReceipt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 3);
            this.textBox1.MinimumSize = new System.Drawing.Size(200, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите текст...";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(450, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // TransactionManagementUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TransactionManagementUCView";
            this.Size = new System.Drawing.Size(528, 31);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
    }
}
