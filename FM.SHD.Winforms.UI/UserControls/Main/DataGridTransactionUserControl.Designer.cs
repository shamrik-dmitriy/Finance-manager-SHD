namespace FM.SHD.Winforms.UI.UserControls.Main
{
    partial class DataGridTransactionUserControl
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
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.СolumnTypeOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.СolumnTypeOperation,
            this.ColumnAccount,
            this.ColumnDate,
            this.ColumnSum,
            this.ColumnChange,
            this.ColumnDelete});
            this.dataGridViewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransaction.MinimumSize = new System.Drawing.Size(300, 300);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.RowTemplate.Height = 25;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(1040, 798);
            this.dataGridViewTransaction.TabIndex = 0;
            // 
            // СolumnTypeOperation
            // 
            this.СolumnTypeOperation.HeaderText = "Тип операции";
            this.СolumnTypeOperation.Name = "СolumnTypeOperation";
            this.СolumnTypeOperation.ReadOnly = true;
            // 
            // ColumnAccount
            // 
            this.ColumnAccount.HeaderText = "Счёт";
            this.ColumnAccount.Name = "ColumnAccount";
            this.ColumnAccount.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnSum
            // 
            this.ColumnSum.HeaderText = "Сумма";
            this.ColumnSum.Name = "ColumnSum";
            this.ColumnSum.ReadOnly = true;
            // 
            // ColumnChange
            // 
            this.ColumnChange.HeaderText = "Изменить";
            this.ColumnChange.Name = "ColumnChange";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Удалить";
            this.ColumnDelete.Name = "ColumnDelete";
            // 
            // DataGridTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridViewTransaction);
            this.Name = "DataGridTransactionUserControl";
            this.Size = new System.Drawing.Size(1040, 798);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn СolumnTypeOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnChange;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}
