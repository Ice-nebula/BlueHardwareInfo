namespace BlueHardwareInfo.Ui.Forms
{
    partial class MainForm
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
            this.lbCategories = new System.Windows.Forms.Label();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lbCategories
            // 
            this.lbCategories.AccessibleName = "categories";
            this.lbCategories.AutoSize = true;
            this.lbCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCategories.Location = new System.Drawing.Point(0, 0);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(56, 13);
            this.lbCategories.TabIndex = 0;
            this.lbCategories.Text = "categories";
            // 
            // tvCategories
            // 
            this.tvCategories.AccessibleName = "categories";
            this.tvCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvCategories.Location = new System.Drawing.Point(56, 0);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(121, 450);
            this.tvCategories.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AccessibleName = "blue hardware info";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvCategories);
            this.Controls.Add(this.lbCategories);
            this.Name = "MainForm";
            this.Text = "blue hardware info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.TreeView tvCategories;
    }
}