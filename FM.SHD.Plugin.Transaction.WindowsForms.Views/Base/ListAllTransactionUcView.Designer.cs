namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Base
{
    partial class ListAllTransactionUcView
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
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebitAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AllowUserToAddRows = false;
            this.dataGridViewTransaction.AllowUserToDeleteRows = false;
            this.dataGridViewTransaction.AllowUserToResizeColumns = false;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnSum,
            this.ColumnDate,
            this.ColumnCategory,
            this.ColumnContragent,
            this.ColumnIdentity,
            this.ColumnDebitAccount,
            this.ColumnCreditAccount});
            this.dataGridViewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransaction.MinimumSize = new System.Drawing.Size(300, 300);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.RowHeadersVisible = false;
            this.dataGridViewTransaction.RowTemplate.Height = 25;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(1040, 798);
            this.dataGridViewTransaction.TabIndex = 0;
            this.dataGridViewTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaction_CellClick);
            this.dataGridViewTransaction.SelectionChanged += new System.EventHandler(this.dataGridViewTransaction_SelectionChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.DataPropertyName = "Description";
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // ColumnSum
            // 
            this.ColumnSum.DataPropertyName = "Sum";
            this.ColumnSum.HeaderText = "Сумма";
            this.ColumnSum.Name = "ColumnSum";
            this.ColumnSum.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "Date";
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.DataPropertyName = "Category";
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // ColumnContragent
            // 
            this.ColumnContragent.DataPropertyName = "Contragent";
            this.ColumnContragent.HeaderText = "Контрагент";
            this.ColumnContragent.Name = "ColumnContragent";
            this.ColumnContragent.ReadOnly = true;
            // 
            // ColumnIdentity
            // 
            this.ColumnIdentity.DataPropertyName = "Identity";
            this.ColumnIdentity.HeaderText = "Член семьи";
            this.ColumnIdentity.Name = "ColumnIdentity";
            this.ColumnIdentity.ReadOnly = true;
            // 
            // ColumnDebitAccount
            // 
            this.ColumnDebitAccount.DataPropertyName = "DebitAccount";
            this.ColumnDebitAccount.HeaderText = "Счёт списания ";
            this.ColumnDebitAccount.Name = "ColumnDebitAccount";
            this.ColumnDebitAccount.ReadOnly = true;
            // 
            // ColumnCreditAccount
            // 
            this.ColumnCreditAccount.DataPropertyName = "CreditAccount";
            this.ColumnCreditAccount.HeaderText = "Счёт зачисления";
            this.ColumnCreditAccount.Name = "ColumnCreditAccount";
            this.ColumnCreditAccount.ReadOnly = true;
            // 
            // ListAllTransactionUcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridViewTransaction);
            this.Name = "ListAllTransactionUcView";
            this.Size = new System.Drawing.Size(1040, 798);
            this.Load += new System.EventHandler(this.DataGridTransactionUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContragent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebitAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditAccount;
    }
}
