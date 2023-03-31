namespace FM.SHD.Plugin.Transaction.WindowsForms.Views
{
    partial class TransactionBaseView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.singleTransactionDesktopflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // singleTransactionDesktopflowLayoutPanel
            // 
            this.singleTransactionDesktopflowLayoutPanel.AutoSize = true;
            this.singleTransactionDesktopflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.singleTransactionDesktopflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleTransactionDesktopflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.singleTransactionDesktopflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.singleTransactionDesktopflowLayoutPanel.Name = "singleTransactionDesktopflowLayoutPanel";
            this.singleTransactionDesktopflowLayoutPanel.Size = new System.Drawing.Size(366, 361);
            this.singleTransactionDesktopflowLayoutPanel.TabIndex = 6;
            // 
            // TransactionBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.singleTransactionDesktopflowLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 400);
            this.Name = "TransactionBaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSingleTransactionView";
            this.Load += new System.EventHandler(this.AddSingleTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel singleTransactionDesktopflowLayoutPanel;
    }
}