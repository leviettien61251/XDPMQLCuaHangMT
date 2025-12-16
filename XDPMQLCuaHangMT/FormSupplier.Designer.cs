using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class FormSupplier
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlBangSupplier = new System.Windows.Forms.Panel();
            this.lblBangSupplier = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput.SuspendLayout();
            this.pnlBangSupplier.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lblName);
            this.pnlInput.Controls.Add(this.textBoxName);
            this.pnlInput.Controls.Add(this.lblContact);
            this.pnlInput.Controls.Add(this.textBoxContact);
            this.pnlInput.Controls.Add(this.lblPhone);
            this.pnlInput.Controls.Add(this.textBoxPhone);
            this.pnlInput.Controls.Add(this.lblEmail);
            this.pnlInput.Controls.Add(this.textBoxEmail);
            this.pnlInput.Controls.Add(this.lblAddress);
            this.pnlInput.Controls.Add(this.textBoxAddress);
            this.pnlInput.Controls.Add(this.btnAdd);
            this.pnlInput.Controls.Add(this.btnUpdate);
            this.pnlInput.Controls.Add(this.btnDelete);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(380, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(16, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên NCC:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(16, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(344, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(200, 73);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(160, 36);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact:";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContact.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.textBoxContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContact.ForeColor = System.Drawing.Color.White;
            this.textBoxContact.Location = new System.Drawing.Point(200, 112);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(160, 26);
            this.textBoxContact.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(16, 73);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 36);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.Location = new System.Drawing.Point(16, 112);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 26);
            this.textBoxPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(16, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 36);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(21, 180);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(339, 26);
            this.textBoxEmail.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(16, 209);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 35);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.ForeColor = System.Drawing.Color.White;
            this.textBoxAddress.Location = new System.Drawing.Point(16, 248);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(344, 26);
            this.textBoxAddress.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(116, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(216, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlBangSupplier
            // 
            this.pnlBangSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBangSupplier.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.pnlBangSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBangSupplier.Controls.Add(this.lblBangSupplier);
            this.pnlBangSupplier.Controls.Add(this.dgv_Supplier);
            this.pnlBangSupplier.Controls.Add(this.pnlTimKiem);
            this.pnlBangSupplier.Location = new System.Drawing.Point(408, 12);
            this.pnlBangSupplier.Name = "pnlBangSupplier";
            this.pnlBangSupplier.Size = new System.Drawing.Size(1184, 639);
            this.pnlBangSupplier.TabIndex = 1;
            // 
            // lblBangSupplier
            // 
            this.lblBangSupplier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBangSupplier.ForeColor = System.Drawing.Color.White;
            this.lblBangSupplier.Location = new System.Drawing.Point(0, 56);
            this.lblBangSupplier.Name = "lblBangSupplier";
            this.lblBangSupplier.Size = new System.Drawing.Size(392, 28);
            this.lblBangSupplier.TabIndex = 0;
            this.lblBangSupplier.Text = "Bảng Nhà cung cấp";
            this.lblBangSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimKiem.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.pnlTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Location = new System.Drawing.Point(10, 10);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1162, 36);
            this.pnlTimKiem.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(6, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1082, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Tìm kiếm nhà cung cấp...";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1094, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 27);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Supplier.ColumnHeadersHeight = 34;
            this.dgv_Supplier.EnableHeadersVisualStyles = false;
            this.dgv_Supplier.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgv_Supplier.Location = new System.Drawing.Point(10, 87);
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.ReadOnly = true;
            this.dgv_Supplier.RowHeadersWidth = 62;
            this.dgv_Supplier.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgv_Supplier.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Supplier.Size = new System.Drawing.Size(1162, 538);
            this.dgv_Supplier.TabIndex = 1;
            this.dgv_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Supplier_CellClick);
            // 
            // columns
            // 
            this.colSupplierId.HeaderText = "Supplier ID";
            this.colSupplierId.MinimumWidth = 8;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;
            this.colSupplierId.DataPropertyName = "SupplierId";
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.DataPropertyName = "Name";
            // 
            this.colContact.HeaderText = "Contact";
            this.colContact.MinimumWidth = 8;
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.DataPropertyName = "Contact";
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.DataPropertyName = "Phone";
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.DataPropertyName = "Email";
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 8;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.DataPropertyName = "Address";

            // ensure columns are present in the grid
            this.dgv_Supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSupplierId,
                this.colName,
                this.colContact,
                this.colPhone,
                this.colEmail,
                this.colAddress
            });

            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.ClientSize = new System.Drawing.Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlBangSupplier);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhà cung cấp";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlBangSupplier.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlInput;
        private Label lblName;
        private TextBox textBoxName;
        private Label lblContact;
        private TextBox textBoxContact;
        private Label lblPhone;
        private TextBox textBoxPhone;
        private Label lblEmail;
        private TextBox textBoxEmail;
        private Label lblAddress;
        private TextBox textBoxAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel pnlBangSupplier;
        private Label lblBangSupplier;
        private Panel pnlTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgv_Supplier;
        private DataGridViewTextBoxColumn colSupplierId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}