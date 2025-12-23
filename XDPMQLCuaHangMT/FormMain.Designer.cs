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
            this.FormTest = new System.Windows.Forms.ToolStripMenuItem();
            this.FormManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.FormAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.FormEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.FormSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.FormStock = new System.Windows.Forms.ToolStripMenuItem();
            this.FormVoucherIN = new System.Windows.Forms.ToolStripMenuItem();
            this.FormVoucherOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRoleId = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelCreateAt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormTest,
            this.FormManagement,
            this.FormVoucherIN,
            this.FormVoucherOUT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormTest
            // 
            this.FormTest.Name = "FormTest";
            this.FormTest.Size = new System.Drawing.Size(68, 20);
            this.FormTest.Text = "FormTest";
            // 
            // FormManagement
            // 
            this.FormManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormAccount,
            this.FormEmployee,
            this.FormSupplier,
            this.FormStock});
            this.FormManagement.Name = "FormManagement";
            this.FormManagement.Size = new System.Drawing.Size(60, 20);
            this.FormManagement.Text = "Quản lý";
            this.FormManagement.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ManagementToolStripMenuItem_DropDownItemClicked);
            // 
            // FormAccount
            // 
            this.FormAccount.Name = "FormAccount";
            this.FormAccount.Size = new System.Drawing.Size(161, 22);
            this.FormAccount.Text = "Tài Khoản";
            this.FormAccount.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.formToolStripMenuItem_DropDownItemClicked);
            // 
            // FormEmployee
            // 
            this.FormEmployee.Name = "FormEmployee";
            this.FormEmployee.Size = new System.Drawing.Size(161, 22);
            this.FormEmployee.Text = "Nhân viên";
            this.FormEmployee.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.formToolStripMenuItem_DropDownItemClicked);
            // 
            // FormSupplier
            // 
            this.FormSupplier.Name = "FormSupplier";
            this.FormSupplier.Size = new System.Drawing.Size(161, 22);
            this.FormSupplier.Text = "Nhà cung cấp";
            this.FormSupplier.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ManagementToolStripMenuItem_DropDownItemClicked);
            // 
            // FormStock
            // 
            this.FormStock.Name = "FormStock";
            this.FormStock.Size = new System.Drawing.Size(161, 22);
            this.FormStock.Text = "Phiếu nhập/xuất";
            // 
            // FormVoucherIN
            // 
            this.FormVoucherIN.Name = "FormVoucherIN";
            this.FormVoucherIN.Size = new System.Drawing.Size(102, 20);
            this.FormVoucherIN.Text = "Phiếu nhập kho";
            this.FormVoucherIN.Click += new System.EventHandler(this.FormVoucherIN_Click_1);
            // 
            // FormVoucherOUT
            // 
            this.FormVoucherOUT.Name = "FormVoucherOUT";
            this.FormVoucherOUT.Size = new System.Drawing.Size(97, 20);
            this.FormVoucherOUT.Text = "Phiếu xuất kho";
            this.FormVoucherOUT.Click += new System.EventHandler(this.FormVoucherOUT_Click);
            // 
            // labelRoleId
            // 
            this.labelRoleId.AutoSize = true;
            this.labelRoleId.Location = new System.Drawing.Point(656, 0);
            this.labelRoleId.Name = "labelRoleId";
            this.labelRoleId.Size = new System.Drawing.Size(44, 13);
            this.labelRoleId.TabIndex = 1;
            this.labelRoleId.Text = "Role Id:";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(724, 0);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(68, 13);
            this.labelEmployeeId.TabIndex = 2;
            this.labelEmployeeId.Text = "Employee Id:";
            // 
            // labelCreateAt
            // 
            this.labelCreateAt.AutoSize = true;
            this.labelCreateAt.Location = new System.Drawing.Point(816, 0);
            this.labelCreateAt.Name = "labelCreateAt";
            this.labelCreateAt.Size = new System.Drawing.Size(60, 13);
            this.labelCreateAt.TabIndex = 3;
            this.labelCreateAt.Text = "Created At:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 578);
            this.Controls.Add(this.labelCreateAt);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.labelRoleId);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelRoleId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelCreateAt;
        private System.Windows.Forms.ToolStripMenuItem FormTest;
        private System.Windows.Forms.ToolStripMenuItem FormManagement;
        private System.Windows.Forms.ToolStripMenuItem FormAccount;
        private System.Windows.Forms.ToolStripMenuItem FormEmployee;
        private System.Windows.Forms.ToolStripMenuItem FormSupplier;
        private System.Windows.Forms.ToolStripMenuItem FormStock;
        private System.Windows.Forms.ToolStripMenuItem FormVoucherIN;
        private System.Windows.Forms.ToolStripMenuItem FormVoucherOUT;
    }
}

