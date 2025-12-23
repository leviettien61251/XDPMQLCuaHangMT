// FormProduct.Designer.cs
// UI-only: phiên bản nền trắng, Designer-friendly, không có mã động trong InitializeComponent.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class ProductForm
    {
        private IContainer components = null;

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
        private Label lblSupplierTable;
        private DataGridView dgvSuppliers;
        private Panel pnlSearchSupplier;
        private TextBox txtSearchSupplier;
        private Button btnSearchSupplier;

        private DataGridViewTextBoxColumn colSupplierId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;

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
            this.pnlInput = new Panel();
            this.labelProductName = new Label();
            this.textBoxProductName = new TextBox();
            this.labelUnit = new Label();
            this.textBoxUnit = new TextBox();
            this.labelSupplier = new Label();
            this.comboBoxSupplier = new ComboBox();
            this.labelPricePerProduct = new Label();
            this.textBoxPricePerProduct = new TextBox();
            this.labelQuantity = new Label();
            this.textBoxQuantity = new TextBox();
            this.labelImportPrice = new Label();
            this.textBoxImportPrice = new TextBox();
            this.buttonAdd = new Button();
            this.buttonUpdate = new Button();
            this.buttonDelete = new Button();
            this.pnlSupplierTable = new Panel();
            this.lblSupplierTable = new Label();
            this.dgvSuppliers = new DataGridView();
            this.colSupplierId = new DataGridViewTextBoxColumn();
            this.colName = new DataGridViewTextBoxColumn();
            this.colContact = new DataGridViewTextBoxColumn();
            this.colPhone = new DataGridViewTextBoxColumn();
            this.colEmail = new DataGridViewTextBoxColumn();
            this.colAddress = new DataGridViewTextBoxColumn();
            this.pnlSearchSupplier = new Panel();
            this.txtSearchSupplier = new TextBox();
            this.btnSearchSupplier = new Button();

            this.pnlInput.SuspendLayout();
            this.pnlSupplierTable.SuspendLayout();
            ((ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlSearchSupplier.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.pnlInput.BackColor = Color.White;
            this.pnlInput.BorderStyle = BorderStyle.None;
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
            this.pnlInput.Location = new Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new Size(380, 639);
            this.pnlInput.TabIndex = 0;

            // labelProductName
            this.labelProductName.Font = new Font("Segoe UI", 10F);
            this.labelProductName.ForeColor = Color.Black;
            this.labelProductName.Location = new Point(16, 10);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new Size(160, 26);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Tên sản phẩm:";

            // textBoxProductName
            this.textBoxProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxProductName.BackColor = Color.White;
            this.textBoxProductName.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxProductName.ForeColor = Color.Black;
            this.textBoxProductName.Location = new Point(16, 44);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new Size(344, 26);
            this.textBoxProductName.TabIndex = 1;

            // labelUnit
            this.labelUnit.Font = new Font("Segoe UI", 10F);
            this.labelUnit.ForeColor = Color.Black;
            this.labelUnit.Location = new Point(200, 73);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new Size(160, 35);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "Đơn vị:";

            // textBoxUnit
            this.textBoxUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxUnit.BackColor = Color.White;
            this.textBoxUnit.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxUnit.ForeColor = Color.Black;
            this.textBoxUnit.Location = new Point(200, 112);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new Size(160, 26);
            this.textBoxUnit.TabIndex = 3;

            // labelSupplier
            this.labelSupplier.Font = new Font("Segoe UI", 10F);
            this.labelSupplier.ForeColor = Color.Black;
            this.labelSupplier.Location = new Point(16, 73);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new Size(160, 35);
            this.labelSupplier.TabIndex = 4;
            this.labelSupplier.Text = "Nhà cung cấp:";

            // comboBoxSupplier
            this.comboBoxSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxSupplier.BackColor = Color.White;
            this.comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.ForeColor = Color.Black;
            this.comboBoxSupplier.Location = new Point(16, 112);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new Size(160, 28);
            this.comboBoxSupplier.TabIndex = 5;

            // labelPricePerProduct
            this.labelPricePerProduct.Font = new Font("Segoe UI", 10F);
            this.labelPricePerProduct.ForeColor = Color.Black;
            this.labelPricePerProduct.Location = new Point(200, 143);
            this.labelPricePerProduct.Name = "labelPricePerProduct";
            this.labelPricePerProduct.Size = new Size(160, 33);
            this.labelPricePerProduct.TabIndex = 6;
            this.labelPricePerProduct.Text = "Đơn Giá:";

            // textBoxPricePerProduct
            this.textBoxPricePerProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxPricePerProduct.BackColor = Color.White;
            this.textBoxPricePerProduct.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxPricePerProduct.ForeColor = Color.Black;
            this.textBoxPricePerProduct.Location = new Point(200, 180);
            this.textBoxPricePerProduct.Name = "textBoxPricePerProduct";
            this.textBoxPricePerProduct.Size = new Size(160, 26);
            this.textBoxPricePerProduct.TabIndex = 7;

            // labelQuantity
            this.labelQuantity.Font = new Font("Segoe UI", 10F);
            this.labelQuantity.ForeColor = Color.Black;
            this.labelQuantity.Location = new Point(16, 143);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new Size(160, 33);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Số lượng:";

            // textBoxQuantity
            this.textBoxQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxQuantity.BackColor = Color.White;
            this.textBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxQuantity.ForeColor = Color.Black;
            this.textBoxQuantity.Location = new Point(16, 180);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new Size(160, 26);
            this.textBoxQuantity.TabIndex = 9;

            // labelImportPrice
            this.labelImportPrice.Font = new Font("Segoe UI", 10F);
            this.labelImportPrice.ForeColor = Color.Black;
            this.labelImportPrice.Location = new Point(16, 209);
            this.labelImportPrice.Name = "labelImportPrice";
            this.labelImportPrice.Size = new Size(160, 35);
            this.labelImportPrice.TabIndex = 10;
            this.labelImportPrice.Text = "Giá nhập:";

            // textBoxImportPrice
            this.textBoxImportPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxImportPrice.BackColor = Color.White;
            this.textBoxImportPrice.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxImportPrice.ForeColor = Color.Black;
            this.textBoxImportPrice.Location = new Point(16, 248);
            this.textBoxImportPrice.Name = "textBoxImportPrice";
            this.textBoxImportPrice.Size = new Size(160, 26);
            this.textBoxImportPrice.TabIndex = 11;

            // buttonAdd
            this.buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonAdd.BackColor = Color.White;
            this.buttonAdd.FlatStyle = FlatStyle.System;
            this.buttonAdd.ForeColor = Color.Black;
            this.buttonAdd.Location = new Point(16, 560);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(80, 30);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;

            // buttonUpdate
            this.buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonUpdate.BackColor = Color.White;
            this.buttonUpdate.FlatStyle = FlatStyle.System;
            this.buttonUpdate.ForeColor = Color.Black;
            this.buttonUpdate.Location = new Point(116, 560);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(80, 30);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;

            // buttonDelete
            this.buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.buttonDelete.BackColor = Color.White;
            this.buttonDelete.FlatStyle = FlatStyle.System;
            this.buttonDelete.ForeColor = Color.Black;
            this.buttonDelete.Location = new Point(216, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(80, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;

            // 
            // pnlSupplierTable
            // 
            this.pnlSupplierTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlSupplierTable.BackColor = Color.White;
            this.pnlSupplierTable.BorderStyle = BorderStyle.None;
            this.pnlSupplierTable.Controls.Add(this.lblSupplierTable);
            this.pnlSupplierTable.Controls.Add(this.dgvSuppliers);
            this.pnlSupplierTable.Controls.Add(this.pnlSearchSupplier);
            this.pnlSupplierTable.Location = new Point(408, 12);
            this.pnlSupplierTable.Name = "pnlSupplierTable";
            this.pnlSupplierTable.Size = new Size(1184, 639);
            this.pnlSupplierTable.TabIndex = 1;

            // lblSupplierTable
            this.lblSupplierTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSupplierTable.ForeColor = Color.Black;
            this.lblSupplierTable.Location = new Point(0, 56);
            this.lblSupplierTable.Name = "lblSupplierTable";
            this.lblSupplierTable.Size = new Size(392, 28);
            this.lblSupplierTable.TabIndex = 0;
            this.lblSupplierTable.Text = "Bảng Nhà cung cấp";
            this.lblSupplierTable.TextAlign = ContentAlignment.MiddleLeft;

            // dgvSuppliers
            this.dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.ColumnHeadersHeight = 34;
            this.dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] {
                this.colSupplierId,
                this.colName,
                this.colContact,
                this.colPhone,
                this.colEmail,
                this.colAddress
            });
            this.dgvSuppliers.EnableHeadersVisualStyles = true;
            this.dgvSuppliers.GridColor = Color.LightGray;
            this.dgvSuppliers.Location = new Point(10, 87);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 62;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new Size(1162, 538);
            this.dgvSuppliers.TabIndex = 1;

            // colSupplierId
            this.colSupplierId.DataPropertyName = "SupplierId";
            this.colSupplierId.HeaderText = "Supplier ID";
            this.colSupplierId.MinimumWidth = 8;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;

            // colName
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;

            // colContact
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "Contact";
            this.colContact.MinimumWidth = 8;
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;

            // colPhone
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;

            // colEmail
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;

            // colAddress
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 8;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;

            // pnlSearchSupplier
            this.pnlSearchSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlSearchSupplier.BackColor = Color.White;
            this.pnlSearchSupplier.BorderStyle = BorderStyle.None;
            this.pnlSearchSupplier.Controls.Add(this.txtSearchSupplier);
            this.pnlSearchSupplier.Controls.Add(this.btnSearchSupplier);
            this.pnlSearchSupplier.Location = new Point(10, 10);
            this.pnlSearchSupplier.Name = "pnlSearchSupplier";
            this.pnlSearchSupplier.Size = new Size(1162, 36);
            this.pnlSearchSupplier.TabIndex = 3;

            // txtSearchSupplier
            this.txtSearchSupplier.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtSearchSupplier.BackColor = Color.White;
            this.txtSearchSupplier.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearchSupplier.ForeColor = Color.Gray;
            this.txtSearchSupplier.Location = new Point(6, 6);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new Size(1082, 26);
            this.txtSearchSupplier.TabIndex = 0;
            this.txtSearchSupplier.Text = "Tìm kiếm nhà cung cấp...";

            // btnSearchSupplier
            this.btnSearchSupplier.Anchor = AnchorStyles.Right;
            this.btnSearchSupplier.BackColor = Color.White;
            this.btnSearchSupplier.FlatStyle = FlatStyle.System;
            this.btnSearchSupplier.ForeColor = Color.Black;
            this.btnSearchSupplier.Location = new Point(1094, 4);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new Size(64, 27);
            this.btnSearchSupplier.TabIndex = 1;
            this.btnSearchSupplier.Text = "Tìm kiếm";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;

            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlSupplierTable);
            this.ForeColor = Color.Black;
            this.MinimumSize = new Size(760, 480);
            this.Name = "FormProduct";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Sản phẩm";

            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlSupplierTable.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlSearchSupplier.ResumeLayout(false);
            this.pnlSearchSupplier.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}