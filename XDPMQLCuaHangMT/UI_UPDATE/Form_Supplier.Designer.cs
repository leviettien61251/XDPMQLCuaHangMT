// FormSupplier.Designer.cs
// UI-only: thiết kế đồng bộ với các form trước, nền trắng, Designer-friendly.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class SupplierForm
    {
        private IContainer components = null;

        private Panel pnlInput;
        private Label lblSupplierName;
        internal TextBox txtSupplierName;
        private Label lblContact;
        internal TextBox txtContact;
        private Label lblPhone;
        internal TextBox txtPhone;
        private Label lblEmail;
        internal TextBox txtEmail;
        private Label lblAddress;
        internal TextBox txtAddress; // single-line text as requested
        private FlowLayoutPanel inputActionPanel;
        internal Button btnAdd;
        internal Button btnEdit;
        internal Button btnDelete;

        private Panel pnlTable;
        private Label lblSupplierTable;
        private Panel pnlSearchSupplier;
        internal TextBox txtSearchSupplier;
        internal Button btnSearchSupplier;
        internal DataGridView dgvSuppliers;

        // Columns
        private DataGridViewTextBoxColumn colSupplierId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colIsActive;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.inputActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblSupplierTable = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchSupplier = new System.Windows.Forms.Panel();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.inputActionPanel.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlSearchSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.lblSupplierName);
            this.pnlInput.Controls.Add(this.txtSupplierName);
            this.pnlInput.Controls.Add(this.lblContact);
            this.pnlInput.Controls.Add(this.txtContact);
            this.pnlInput.Controls.Add(this.lblPhone);
            this.pnlInput.Controls.Add(this.txtPhone);
            this.pnlInput.Controls.Add(this.lblEmail);
            this.pnlInput.Controls.Add(this.txtEmail);
            this.pnlInput.Controls.Add(this.lblAddress);
            this.pnlInput.Controls.Add(this.txtAddress);
            this.pnlInput.Controls.Add(this.inputActionPanel);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(380, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierName.Location = new System.Drawing.Point(16, 10);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(193, 26);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Tên Nhà cung cấp:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(16, 44);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(344, 26);
            this.txtSupplierName.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(16, 80);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(160, 26);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact:";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(16, 114);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(344, 26);
            this.txtContact.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(16, 150);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 26);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(16, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(344, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(16, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 26);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(16, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(16, 290);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 26);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(16, 324);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(344, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // inputActionPanel
            // 
            this.inputActionPanel.Controls.Add(this.btnAdd);
            this.inputActionPanel.Controls.Add(this.btnEdit);
            this.inputActionPanel.Controls.Add(this.btnDelete);
            this.inputActionPanel.Location = new System.Drawing.Point(16, 384);
            this.inputActionPanel.Name = "inputActionPanel";
            this.inputActionPanel.Size = new System.Drawing.Size(344, 40);
            this.inputActionPanel.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(84, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(165, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Controls.Add(this.lblSupplierTable);
            this.pnlTable.Controls.Add(this.dgvSuppliers);
            this.pnlTable.Controls.Add(this.pnlSearchSupplier);
            this.pnlTable.Location = new System.Drawing.Point(408, 12);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1184, 639);
            this.pnlTable.TabIndex = 1;
            // 
            // lblSupplierTable
            // 
            this.lblSupplierTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSupplierTable.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierTable.Location = new System.Drawing.Point(0, 56);
            this.lblSupplierTable.Name = "lblSupplierTable";
            this.lblSupplierTable.Size = new System.Drawing.Size(392, 28);
            this.lblSupplierTable.TabIndex = 0;
            this.lblSupplierTable.Text = "Bảng Nhà cung cấp";
            this.lblSupplierTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeight = 34;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSupplierId,
            this.colName,
            this.colContact,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colIsActive});
            this.dgvSuppliers.GridColor = System.Drawing.Color.LightGray;
            this.dgvSuppliers.Location = new System.Drawing.Point(10, 87);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 62;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(1162, 538);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // colSupplierId
            // 
            this.colSupplierId.DataPropertyName = "SupplierId";
            this.colSupplierId.HeaderText = "Supplier ID";
            this.colSupplierId.MinimumWidth = 8;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "Contact";
            this.colContact.MinimumWidth = 8;
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 8;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.MinimumWidth = 8;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // pnlSearchSupplier
            // 
            this.pnlSearchSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchSupplier.BackColor = System.Drawing.Color.White;
            this.pnlSearchSupplier.Controls.Add(this.txtSearchSupplier);
            this.pnlSearchSupplier.Controls.Add(this.btnSearchSupplier);
            this.pnlSearchSupplier.Location = new System.Drawing.Point(10, 10);
            this.pnlSearchSupplier.Name = "pnlSearchSupplier";
            this.pnlSearchSupplier.Size = new System.Drawing.Size(1162, 36);
            this.pnlSearchSupplier.TabIndex = 3;
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSupplier.BackColor = System.Drawing.Color.White;
            this.txtSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSupplier.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchSupplier.Location = new System.Drawing.Point(6, 6);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(1082, 26);
            this.txtSearchSupplier.TabIndex = 0;
            this.txtSearchSupplier.Text = "Tìm kiếm nhà cung cấp...";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchSupplier.BackColor = System.Drawing.Color.White;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1094, 4);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(64, 27);
            this.btnSearchSupplier.TabIndex = 1;
            this.btnSearchSupplier.Text = "Tìm kiếm";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhà cung cấp";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.inputActionPanel.ResumeLayout(false);
            this.inputActionPanel.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlSearchSupplier.ResumeLayout(false);
            this.pnlSearchSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}