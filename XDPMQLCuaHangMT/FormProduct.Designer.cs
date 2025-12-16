using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.labelPricePerProduct = new System.Windows.Forms.Label();
            this.textBoxPricePerProduct = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelImportPrice = new System.Windows.Forms.Label();
            this.textBoxImportPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pnlSupplierTable = new System.Windows.Forms.Panel();
            this.lblSupplierTable = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchSupplier = new System.Windows.Forms.Panel();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.pnlSupplierTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlSearchSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.labelProductName);
            this.pnlInput.Controls.Add(this.textBoxProductName);
            this.pnlInput.Controls.Add(this.labelUnit);
            this.pnlInput.Controls.Add(this.textBoxUnit);
            this.pnlInput.Controls.Add(this.labelSupplier);
            this.pnlInput.Controls.Add(this.comboBoxSupplier);
            this.pnlInput.Controls.Add(this.labelPricePerProduct);
            this.pnlInput.Controls.Add(this.textBoxPricePerProduct);
            this.pnlInput.Controls.Add(this.labelQuantity);
            this.pnlInput.Controls.Add(this.textBoxQuantity);
            this.pnlInput.Controls.Add(this.labelImportPrice);
            this.pnlInput.Controls.Add(this.textBoxImportPrice);
            this.pnlInput.Controls.Add(this.buttonAdd);
            this.pnlInput.Controls.Add(this.buttonUpdate);
            this.pnlInput.Controls.Add(this.buttonDelete);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(380, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelProductName.ForeColor = System.Drawing.Color.White;
            this.labelProductName.Location = new System.Drawing.Point(16, 10);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(160, 26);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Tên sản phẩm:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(16, 44);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(344, 26);
            this.textBoxProductName.TabIndex = 1;
            // 
            // labelUnit
            // 
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUnit.ForeColor = System.Drawing.Color.White;
            this.labelUnit.Location = new System.Drawing.Point(200, 73);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(160, 35);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "Đơn vị:";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUnit.ForeColor = System.Drawing.Color.White;
            this.textBoxUnit.Location = new System.Drawing.Point(200, 112);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(160, 26);
            this.textBoxUnit.TabIndex = 3;
            // 
            // labelSupplier
            // 
            this.labelSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSupplier.ForeColor = System.Drawing.Color.White;
            this.labelSupplier.Location = new System.Drawing.Point(16, 73);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(160, 35);
            this.labelSupplier.TabIndex = 4;
            this.labelSupplier.Text = "Nhà cung cấp:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.ForeColor = System.Drawing.Color.White;
            this.comboBoxSupplier.Location = new System.Drawing.Point(16, 112);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(160, 28);
            this.comboBoxSupplier.TabIndex = 5;
            // 
            // labelPricePerProduct
            // 
            this.labelPricePerProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPricePerProduct.ForeColor = System.Drawing.Color.White;
            this.labelPricePerProduct.Location = new System.Drawing.Point(200, 143);
            this.labelPricePerProduct.Name = "labelPricePerProduct";
            this.labelPricePerProduct.Size = new System.Drawing.Size(160, 33);
            this.labelPricePerProduct.TabIndex = 6;
            this.labelPricePerProduct.Text = "Giá trên 1 sản phẩm:";
            // 
            // textBoxPricePerProduct
            // 
            this.textBoxPricePerProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPricePerProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxPricePerProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPricePerProduct.ForeColor = System.Drawing.Color.White;
            this.textBoxPricePerProduct.Location = new System.Drawing.Point(200, 180);
            this.textBoxPricePerProduct.Name = "textBoxPricePerProduct";
            this.textBoxPricePerProduct.Size = new System.Drawing.Size(160, 26);
            this.textBoxPricePerProduct.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(16, 143);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(160, 33);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Số lượng:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuantity.ForeColor = System.Drawing.Color.White;
            this.textBoxQuantity.Location = new System.Drawing.Point(16, 180);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(160, 26);
            this.textBoxQuantity.TabIndex = 9;
            // 
            // labelImportPrice
            // 
            this.labelImportPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelImportPrice.ForeColor = System.Drawing.Color.White;
            this.labelImportPrice.Location = new System.Drawing.Point(16, 209);
            this.labelImportPrice.Name = "labelImportPrice";
            this.labelImportPrice.Size = new System.Drawing.Size(160, 35);
            this.labelImportPrice.TabIndex = 10;
            this.labelImportPrice.Text = "Giá nhập:";
            // 
            // textBoxImportPrice
            // 
            this.textBoxImportPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImportPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxImportPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImportPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxImportPrice.Location = new System.Drawing.Point(16, 248);
            this.textBoxImportPrice.Name = "textBoxImportPrice";
            this.textBoxImportPrice.Size = new System.Drawing.Size(160, 26);
            this.textBoxImportPrice.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(16, 560);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(116, 560);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(216, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // pnlSupplierTable
            // 
            this.pnlSupplierTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSupplierTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlSupplierTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSupplierTable.Controls.Add(this.lblSupplierTable);
            this.pnlSupplierTable.Controls.Add(this.dgvSuppliers);
            this.pnlSupplierTable.Controls.Add(this.pnlSearchSupplier);
            this.pnlSupplierTable.Location = new System.Drawing.Point(408, 12);
            this.pnlSupplierTable.Name = "pnlSupplierTable";
            this.pnlSupplierTable.Size = new System.Drawing.Size(1184, 639);
            this.pnlSupplierTable.TabIndex = 1;
            // 
            // lblSupplierTable
            // 
            this.lblSupplierTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSupplierTable.ForeColor = System.Drawing.Color.White;
            this.lblSupplierTable.Location = new System.Drawing.Point(0, 56);
            this.lblSupplierTable.Name = "lblSupplierTable";
            this.lblSupplierTable.Size = new System.Drawing.Size(392, 28);
            this.lblSupplierTable.TabIndex = 0;
            this.lblSupplierTable.Text = "Bảng Nhà cung cấp";
            this.lblSupplierTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.ColumnHeadersHeight = 34;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSupplierId,
            this.colName,
            this.colContact,
            this.colPhone,
            this.colEmail,
            this.colAddress});
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvSuppliers.Location = new System.Drawing.Point(10, 87);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 62;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
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
            // pnlSearchSupplier
            // 
            this.pnlSearchSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.txtSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
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
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1094, 4);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(64, 27);
            this.btnSearchSupplier.TabIndex = 1;
            this.btnSearchSupplier.Text = "Tìm kiếm";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlSupplierTable);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Sản phẩm";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlSupplierTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlSearchSupplier.ResumeLayout(false);
            this.pnlSearchSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlInput;
        private Label labelProductName;
        private TextBox textBoxProductName;
        private Label labelUnit;
        private TextBox textBoxUnit;
        private Label labelSupplier;
        private ComboBox comboBoxSupplier;
        private Label labelPricePerProduct;
        private TextBox textBoxPricePerProduct;
        private Label labelQuantity;
        private TextBox textBoxQuantity;
        private Label labelImportPrice;
        private TextBox textBoxImportPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Panel pnlSupplierTable;
        private Panel pnlSearchSupplier;
        private TextBox txtSearchSupplier;
        private Button btnSearchSupplier;
        private Label lblSupplierTable;
        private DataGridView dgvSuppliers;
        private DataGridViewTextBoxColumn colSupplierId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}