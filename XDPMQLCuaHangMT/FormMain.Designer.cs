namespace XDPMQLCuaHangMT
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRoleId = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelCreateAt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // labelRoleId
            // 
            this.labelRoleId.AutoSize = true;
            this.labelRoleId.Location = new System.Drawing.Point(12, 24);
            this.labelRoleId.Name = "labelRoleId";
            this.labelRoleId.Size = new System.Drawing.Size(44, 13);
            this.labelRoleId.TabIndex = 1;
            this.labelRoleId.Text = "Role Id:";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(12, 37);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(68, 13);
            this.labelEmployeeId.TabIndex = 2;
            this.labelEmployeeId.Text = "Employee Id:";
            // 
            // labelCreateAt
            // 
            this.labelCreateAt.AutoSize = true;
            this.labelCreateAt.Location = new System.Drawing.Point(12, 50);
            this.labelCreateAt.Name = "labelCreateAt";
            this.labelCreateAt.Size = new System.Drawing.Size(60, 13);
            this.labelCreateAt.TabIndex = 3;
            this.labelCreateAt.Text = "Created At:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCreateAt);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.labelRoleId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.Label labelRoleId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelCreateAt;
    }
}

