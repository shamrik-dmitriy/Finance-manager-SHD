
namespace SHDML.Winforms.UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.splitContainerMainDesktop = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlAuth1 = new SHDML.Winforms.UI.UserControls.UserControlAuth();
            this.buttonSign = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonTransactionReview = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainDesktop)).BeginInit();
            this.splitContainerMainDesktop.Panel1.SuspendLayout();
            this.splitContainerMainDesktop.Panel2.SuspendLayout();
            this.splitContainerMainDesktop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMainDesktop
            // 
            this.splitContainerMainDesktop.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainerMainDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainDesktop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainDesktop.Name = "splitContainerMainDesktop";
            this.splitContainerMainDesktop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainDesktop.Panel1
            // 
            this.splitContainerMainDesktop.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMainDesktop.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainerMainDesktop.Panel2
            // 
            this.splitContainerMainDesktop.Panel2.Controls.Add(this.label1);
            this.splitContainerMainDesktop.Size = new System.Drawing.Size(1208, 627);
            this.splitContainerMainDesktop.SplitterDistance = 81;
            this.splitContainerMainDesktop.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonSign);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.buttonTransactionReview);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.buttonCategories);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 57);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlAuth1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 49);
            this.panel1.TabIndex = 17;
            // 
            // userControlAuth1
            // 
            this.userControlAuth1.AutoSize = true;
            this.userControlAuth1.Location = new System.Drawing.Point(9, 3);
            this.userControlAuth1.MaximumSize = new System.Drawing.Size(198, 40);
            this.userControlAuth1.MinimumSize = new System.Drawing.Size(198, 40);
            this.userControlAuth1.Name = "userControlAuth1";
            this.userControlAuth1.Size = new System.Drawing.Size(198, 40);
            this.userControlAuth1.TabIndex = 0;
            // 
            // buttonSign
            // 
            this.buttonSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSign.Location = new System.Drawing.Point(219, 3);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(75, 49);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "Войти";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(300, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 49);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // buttonTransactionReview
            // 
            this.buttonTransactionReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionReview.Location = new System.Drawing.Point(309, 3);
            this.buttonTransactionReview.Name = "buttonTransactionReview";
            this.buttonTransactionReview.Size = new System.Drawing.Size(84, 49);
            this.buttonTransactionReview.TabIndex = 5;
            this.buttonTransactionReview.Text = "Обзор транзакций";
            this.buttonTransactionReview.UseVisualStyleBackColor = true;
            this.buttonTransactionReview.Click += new System.EventHandler(this.buttonTransactionReview_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(399, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 49);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // buttonCategories
            // 
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.Location = new System.Drawing.Point(408, 3);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(75, 49);
            this.buttonCategories.TabIndex = 7;
            this.buttonCategories.Text = "Категории";
            this.buttonCategories.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 627);
            this.Controls.Add(this.splitContainerMainDesktop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerMainDesktop.Panel1.ResumeLayout(false);
            this.splitContainerMainDesktop.Panel1.PerformLayout();
            this.splitContainerMainDesktop.Panel2.ResumeLayout(false);
            this.splitContainerMainDesktop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainDesktop)).EndInit();
            this.splitContainerMainDesktop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainerMainDesktop;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.Button buttonSign;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Button buttonTransactionReview;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Panel panel1;
        private UserControls.UserControlAuth userControlAuth1;
        public System.Windows.Forms.Label label1;
    }
}

