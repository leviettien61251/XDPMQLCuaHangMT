using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class FormStockDetail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVoucherId = new System.Windows.Forms.Label();
            this.textBoxStockId = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlDetailSearch = new System.Windows.Forms.Panel();
            this.txtSearchDetail = new System.Windows.Forms.TextBox();
            this.btnSearchDetail = new System.Windows.Forms.Button();
            this.lblDetailTable = new System.Windows.Forms.Label();
            this.dgvDetailStock = new System.Windows.Forms.DataGridView();
            this.colDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductSearch = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.lblProductTable = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pcolProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcolMinThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailStock)).BeginInit();
            this.pnlProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.lblVoucherId);
            this.pnlInput.Controls.Add(this.textBoxStockId);
            this.pnlInput.Controls.Add(this.lblProduct);
            this.pnlInput.Controls.Add(this.textBoxProduct);
            this.pnlInput.Controls.Add(this.lblQuantity);
            this.pnlInput.Controls.Add(this.textBoxQuantity);
            this.pnlInput.Controls.Add(this.lblUnitPrice);
            this.pnlInput.Controls.Add(this.textBoxUnitPrice);
            this.pnlInput.Controls.Add(this.buttonAdd);
            this.pnlInput.Controls.Add(this.buttonUpdate);
            this.pnlInput.Controls.Add(this.buttonDelete);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(380, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phiếu nhập/ xuất";
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVoucherId.ForeColor = System.Drawing.Color.White;
            this.lblVoucherId.Location = new System.Drawing.Point(12, 79);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(120, 37);
            this.lblVoucherId.TabIndex = 1;
            this.lblVoucherId.Text = "ID phiếu:";
            // 
            // textBoxStockId
            // 
            this.textBoxStockId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxStockId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStockId.ForeColor = System.Drawing.Color.White;
            this.textBoxStockId.Location = new System.Drawing.Point(8, 119);
            this.textBoxStockId.Name = "textBoxStockId";
            this.textBoxStockId.Size = new System.Drawing.Size(360, 26);
            this.textBoxStockId.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(8, 148);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(120, 29);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Tên sản phẩm:";
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProduct.ForeColor = System.Drawing.Color.White;
            this.textBoxProduct.Location = new System.Drawing.Point(8, 190);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(360, 26);
            this.textBoxProduct.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(12, 236);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 38);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuantity.ForeColor = System.Drawing.Color.White;
            this.textBoxQuantity.Location = new System.Drawing.Point(8, 277);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(360, 26);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(8, 318);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(200, 25);
            this.lblUnitPrice.TabIndex = 7;
            this.lblUnitPrice.Text = "Giá trên 1 sản phẩm:";
            this.lblUnitPrice.Click += new System.EventHandler(this.lblUnitPrice_Click);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUnitPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxUnitPrice.Location = new System.Drawing.Point(8, 362);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(360, 26);
            this.textBoxUnitPrice.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(8, 560);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(108, 560);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(208, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.pnlDetailSearch);
            this.pnlRight.Controls.Add(this.lblDetailTable);
            this.pnlRight.Controls.Add(this.dgvDetailStock);
            this.pnlRight.Controls.Add(this.pnlProductSearch);
            this.pnlRight.Controls.Add(this.lblProductTable);
            this.pnlRight.Controls.Add(this.dgvProduct);
            this.pnlRight.Location = new System.Drawing.Point(408, 12);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1225, 639);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlDetailSearch
            // 
            this.pnlDetailSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlDetailSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailSearch.Controls.Add(this.txtSearchDetail);
            this.pnlDetailSearch.Controls.Add(this.btnSearchDetail);
            this.pnlDetailSearch.Location = new System.Drawing.Point(10, 10);
            this.pnlDetailSearch.Name = "pnlDetailSearch";
            this.pnlDetailSearch.Size = new System.Drawing.Size(540, 36);
            this.pnlDetailSearch.TabIndex = 0;
            // 
            // txtSearchDetail
            // 
            this.txtSearchDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSearchDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDetail.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchDetail.Location = new System.Drawing.Point(6, 6);
            this.txtSearchDetail.Name = "txtSearchDetail";
            this.txtSearchDetail.Size = new System.Drawing.Size(456, 26);
            this.txtSearchDetail.TabIndex = 0;
            this.txtSearchDetail.Text = "Tìm kiếm chi tiết...";
            // 
            // btnSearchDetail
            // 
            this.btnSearchDetail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchDetail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDetail.ForeColor = System.Drawing.Color.White;
            this.btnSearchDetail.Location = new System.Drawing.Point(468, 4);
            this.btnSearchDetail.Name = "btnSearchDetail";
            this.btnSearchDetail.Size = new System.Drawing.Size(64, 27);
            this.btnSearchDetail.TabIndex = 1;
            this.btnSearchDetail.Text = "Tìm kiếm";
            this.btnSearchDetail.UseVisualStyleBackColor = false;
            // 
            // lblDetailTable
            // 
            this.lblDetailTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetailTable.ForeColor = System.Drawing.Color.White;
            this.lblDetailTable.Location = new System.Drawing.Point(10, 56);
            this.lblDetailTable.Name = "lblDetailTable";
            this.lblDetailTable.Size = new System.Drawing.Size(540, 28);
            this.lblDetailTable.TabIndex = 1;
            this.lblDetailTable.Text = "Bảng chi tiết phiếu nhập/xuất";
            this.lblDetailTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetailStock
            // 
            this.dgvDetailStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailStock.ColumnHeadersHeight = 34;
            this.dgvDetailStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailId,
            this.colVoucherId,
            this.colProductId,
            this.colQuantity,
            this.colUnitPrice});
            this.dgvDetailStock.EnableHeadersVisualStyles = false;
            this.dgvDetailStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvDetailStock.Location = new System.Drawing.Point(10, 88);
            this.dgvDetailStock.Name = "dgvDetailStock";
            this.dgvDetailStock.ReadOnly = true;
            this.dgvDetailStock.RowHeadersWidth = 62;
            this.dgvDetailStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvDetailStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetailStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailStock.Size = new System.Drawing.Size(1201, 240);
            this.dgvDetailStock.TabIndex = 2;
            // 
            // colDetailId
            // 
            this.colDetailId.DataPropertyName = "detailId";
            this.colDetailId.HeaderText = "Detail ID";
            this.colDetailId.MinimumWidth = 8;
            this.colDetailId.Name = "colDetailId";
            this.colDetailId.ReadOnly = true;
            // 
            // colVoucherId
            // 
            this.colVoucherId.DataPropertyName = "voucherId";
            this.colVoucherId.HeaderText = "Voucher ID";
            this.colVoucherId.MinimumWidth = 8;
            this.colVoucherId.Name = "colVoucherId";
            this.colVoucherId.ReadOnly = true;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "productId";
            this.colProductId.HeaderText = "Product ID";
            this.colProductId.MinimumWidth = 8;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "unitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.MinimumWidth = 8;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // pnlProductSearch
            // 
            this.pnlProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductSearch.Controls.Add(this.txtSearchProduct);
            this.pnlProductSearch.Controls.Add(this.btnSearchProduct);
            this.pnlProductSearch.Location = new System.Drawing.Point(10, 340);
            this.pnlProductSearch.Name = "pnlProductSearch";
            this.pnlProductSearch.Size = new System.Drawing.Size(540, 36);
            this.pnlProductSearch.TabIndex = 3;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchProduct.Location = new System.Drawing.Point(6, 6);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(456, 26);
            this.txtSearchProduct.TabIndex = 0;
            this.txtSearchProduct.Text = "Tìm kiếm sản phẩm...";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(468, 4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(64, 27);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // lblProductTable
            // 
            this.lblProductTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductTable.ForeColor = System.Drawing.Color.White;
            this.lblProductTable.Location = new System.Drawing.Point(10, 380);
            this.lblProductTable.Name = "lblProductTable";
            this.lblProductTable.Size = new System.Drawing.Size(540, 28);
            this.lblProductTable.TabIndex = 4;
            this.lblProductTable.Text = "Bảng sản phẩm";
            this.lblProductTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 34;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcolProductId,
            this.pcolSKU,
            this.pcolProductName,
            this.pcolSupplierId,
            this.pcolUnit,
            this.pcolUnitPrice,
            this.pcolCostPrice,
            this.pcolStockQuantity,
            this.pcolMinThreshold});
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvProduct.Location = new System.Drawing.Point(10, 412);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1201, 220);
            this.dgvProduct.TabIndex = 5;
            // 
            // pcolProductId
            // 
            this.pcolProductId.DataPropertyName = "productId";
            this.pcolProductId.HeaderText = "Product ID";
            this.pcolProductId.MinimumWidth = 8;
            this.pcolProductId.Name = "pcolProductId";
            this.pcolProductId.ReadOnly = true;
            // 
            // pcolSKU
            // 
            this.pcolSKU.DataPropertyName = "SKU";
            this.pcolSKU.HeaderText = "SKU";
            this.pcolSKU.MinimumWidth = 8;
            this.pcolSKU.Name = "pcolSKU";
            this.pcolSKU.ReadOnly = true;
            // 
            // pcolProductName
            // 
            this.pcolProductName.DataPropertyName = "productName";
            this.pcolProductName.HeaderText = "Product Name";
            this.pcolProductName.MinimumWidth = 8;
            this.pcolProductName.Name = "pcolProductName";
            this.pcolProductName.ReadOnly = true;
            // 
            // pcolSupplierId
            // 
            this.pcolSupplierId.DataPropertyName = "supplierId";
            this.pcolSupplierId.HeaderText = "Supplier ID";
            this.pcolSupplierId.MinimumWidth = 8;
            this.pcolSupplierId.Name = "pcolSupplierId";
            this.pcolSupplierId.ReadOnly = true;
            // 
            // pcolUnit
            // 
            this.pcolUnit.DataPropertyName = "unit";
            this.pcolUnit.HeaderText = "Unit";
            this.pcolUnit.MinimumWidth = 8;
            this.pcolUnit.Name = "pcolUnit";
            this.pcolUnit.ReadOnly = true;
            // 
            // pcolUnitPrice
            // 
            this.pcolUnitPrice.DataPropertyName = "unitPrice";
            this.pcolUnitPrice.HeaderText = "Unit Price";
            this.pcolUnitPrice.MinimumWidth = 8;
            this.pcolUnitPrice.Name = "pcolUnitPrice";
            this.pcolUnitPrice.ReadOnly = true;
            // 
            // pcolCostPrice
            // 
            this.pcolCostPrice.DataPropertyName = "costPrice";
            this.pcolCostPrice.HeaderText = "Cost Price";
            this.pcolCostPrice.MinimumWidth = 8;
            this.pcolCostPrice.Name = "pcolCostPrice";
            this.pcolCostPrice.ReadOnly = true;
            // 
            // pcolStockQuantity
            // 
            this.pcolStockQuantity.DataPropertyName = "stockQuantity";
            this.pcolStockQuantity.HeaderText = "Stock Quantity";
            this.pcolStockQuantity.MinimumWidth = 8;
            this.pcolStockQuantity.Name = "pcolStockQuantity";
            this.pcolStockQuantity.ReadOnly = true;
            // 
            // pcolMinThreshold
            // 
            this.pcolMinThreshold.DataPropertyName = "minThreshold";
            this.pcolMinThreshold.HeaderText = "Min Threshold";
            this.pcolMinThreshold.MinimumWidth = 8;
            this.pcolMinThreshold.Name = "pcolMinThreshold";
            this.pcolMinThreshold.ReadOnly = true;
            // 
            // FormStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1645, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlRight);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "FormStockDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Chi tiết phiếu nhập/ xuất";
            this.Load += new System.EventHandler(this.FormStockDetail_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlDetailSearch.ResumeLayout(false);
            this.pnlDetailSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailStock)).EndInit();
            this.pnlProductSearch.ResumeLayout(false);
            this.pnlProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlInput;
        private Label lblTitle;
        private Label lblVoucherId;
        private TextBox textBoxStockId;
        private Label lblProduct;
        private TextBox textBoxProduct;
        private Label lblQuantity;
        private TextBox textBoxQuantity;
        private Label lblUnitPrice;
        private TextBox textBoxUnitPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Panel pnlRight;
        private Panel pnlDetailSearch;
        private TextBox txtSearchDetail;
        private Button btnSearchDetail;
        private Label lblDetailTable;
        private DataGridView dgvDetailStock;
        private DataGridViewTextBoxColumn colDetailId;
        private DataGridViewTextBoxColumn colVoucherId;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnitPrice;
        private Panel pnlProductSearch;
        private TextBox txtSearchProduct;
        private Button btnSearchProduct;
        private Label lblProductTable;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn pcolProductId;
        private DataGridViewTextBoxColumn pcolSKU;
        private DataGridViewTextBoxColumn pcolProductName;
        private DataGridViewTextBoxColumn pcolSupplierId;
        private DataGridViewTextBoxColumn pcolUnit;
        private DataGridViewTextBoxColumn pcolUnitPrice;
        private DataGridViewTextBoxColumn pcolCostPrice;
        private DataGridViewTextBoxColumn pcolStockQuantity;
        private DataGridViewTextBoxColumn pcolMinThreshold;
    }
}