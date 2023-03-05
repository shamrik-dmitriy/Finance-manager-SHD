
namespace FM.SHD.Plugins.Shared.UI
{
    partial class TabPageContent
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
            this.splitContainerDesktop = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelButtonsBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).BeginInit();
            this.splitContainerDesktop.Panel1.SuspendLayout();
            this.splitContainerDesktop.SuspendLayout();
            this.flowLayoutPanelButtonsBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerDesktop
            // 
            this.splitContainerDesktop.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDesktop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerDesktop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDesktop.Name = "splitContainerDesktop";
            this.splitContainerDesktop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDesktop.Panel1
            // 
            this.splitContainerDesktop.Panel1.Controls.Add(this.flowLayoutPanelButtonsBlock);
            this.splitContainerDesktop.Panel1MinSize = 27;
            this.splitContainerDesktop.Size = new System.Drawing.Size(481, 291);
            this.splitContainerDesktop.SplitterDistance = 30;
            this.splitContainerDesktop.TabIndex = 4;
            // 
            // flowLayoutPanelButtonsBlock
            // 
            this.flowLayoutPanelButtonsBlock.Controls.Add(this.buttonAddReceipt);
            this.flowLayoutPanelButtonsBlock.Controls.Add(this.buttonAddTransaction);
            this.flowLayoutPanelButtonsBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtonsBlock.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtonsBlock.Name = "flowLayoutPanelButtonsBlock";
            this.flowLayoutPanelButtonsBlock.Size = new System.Drawing.Size(481, 30);
            this.flowLayoutPanelButtonsBlock.TabIndex = 0;
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.Location = new System.Drawing.Point(3, 3);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(116, 23);
            this.buttonAddReceipt.TabIndex = 3;
            this.buttonAddReceipt.Text = "Добавить чек";
            this.buttonAddReceipt.UseVisualStyleBackColor = true;
            this.buttonAddReceipt.Visible = false;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(125, 3);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(132, 23);
            this.buttonAddTransaction.TabIndex = 1;
            this.buttonAddTransaction.Text = "Добавить операцию";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TabPageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerDesktop);
            this.Name = "TabPageContent";
            this.Size = new System.Drawing.Size(481, 291);
            this.splitContainerDesktop.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).EndInit();
            this.splitContainerDesktop.ResumeLayout(false);
            this.flowLayoutPanelButtonsBlock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDesktop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtonsBlock;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.Button buttonAddTransaction;
    }
}
