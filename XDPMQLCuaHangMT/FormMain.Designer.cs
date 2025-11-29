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
            this.FormSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.FormTest = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRoleId = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelCreateAt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormSupplier,
            this.FormTest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.formToolStripMenuItem_DropDownItemClicked);
            // 
            // FormSupplier
            // 
            this.FormSupplier.Name = "FormSupplier";
            this.FormSupplier.Size = new System.Drawing.Size(62, 20);
            this.FormSupplier.Text = "Supplier";
            // 
            // FormTest
            // 
            this.FormTest.Name = "FormTest";
            this.FormTest.Size = new System.Drawing.Size(68, 20);
            this.FormTest.Text = "FormTest";
            // 
            // labelRoleId
            // 
            this.labelRoleId.AutoSize = true;
            this.labelRoleId.Location = new System.Drawing.Point(798, 0);
            this.labelRoleId.Name = "labelRoleId";
            this.labelRoleId.Size = new System.Drawing.Size(44, 13);
            this.labelRoleId.TabIndex = 1;
            this.labelRoleId.Text = "Role Id:";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(866, 0);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(68, 13);
            this.labelEmployeeId.TabIndex = 2;
            this.labelEmployeeId.Text = "Employee Id:";
            // 
            // labelCreateAt
            // 
            this.labelCreateAt.AutoSize = true;
            this.labelCreateAt.Location = new System.Drawing.Point(958, 0);
            this.labelCreateAt.Name = "labelCreateAt";
            this.labelCreateAt.Size = new System.Drawing.Size(60, 13);
            this.labelCreateAt.TabIndex = 3;
            this.labelCreateAt.Text = "Created At:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 578);
            this.Controls.Add(this.labelCreateAt);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.labelRoleId);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FormSupplier;
        private System.Windows.Forms.Label labelRoleId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelCreateAt;
        private System.Windows.Forms.ToolStripMenuItem FormTest;
    }
}

