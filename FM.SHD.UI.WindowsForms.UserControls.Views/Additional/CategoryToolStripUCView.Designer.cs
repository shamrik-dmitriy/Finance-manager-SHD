
namespace FM.SHD.UI.WindowsForms.UserControls.Views.Additional
{
    partial class CategoryToolStripUCView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryToolStripUCView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonCategories = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.categoriesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(3, 6);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(38, 15);
            this.categoriesLabel.TabIndex = 0;
            this.categoriesLabel.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonCategories});
            this.toolStrip1.Location = new System.Drawing.Point(44, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(316, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonCategories
            // 
            this.toolStripDropDownButtonCategories.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButtonCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonCategories.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonCategories.Image")));
            this.toolStripDropDownButtonCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonCategories.Name = "toolStripDropDownButtonCategories";
            this.toolStripDropDownButtonCategories.Size = new System.Drawing.Size(164, 25);
            this.toolStripDropDownButtonCategories.Text = "toolStripDropDownButton1";
            // 
            // CategoryToolStripUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CategoryToolStripUCView";
            this.Size = new System.Drawing.Size(360, 28);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonCategories;
    }
}
