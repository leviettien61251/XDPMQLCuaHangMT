// FormStockDetail.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.UI_UPDATE
{
    partial class Form_StockDetail
    {
        private IContainer components = null;

        // Left input
        private Panel pnlInput;
        private Label lblVoucherCode;
        internal TextBox txtVoucherCode;
        private Label lblProductCode;
        internal TextBox txtProductCode;
        private Label lblEmployeeName;
        internal TextBox txtEmployeeName;
        private Label lblProductName;
        internal TextBox txtProductName;
        private Label lblDate;
        internal DateTimePicker dtpDate;
        private Label lblQuantity;
        internal TextBox txtQuantity;
        private Label lblType;
        internal ComboBox cboType;
        private Label lblUnitPrice;
        internal TextBox txtUnitPrice;

        // Action buttons
        private FlowLayoutPanel actionPanel;
        internal Button btnAdd;
        internal Button btnEdit;
        internal Button btnDelete;
        internal Button btnPrint;

        // Right tables
        private Panel pnlRight;
        private Panel pnlDetailTable;
        private Panel pnlSearchDetail;
        internal TextBox txtSearchDetail;
        internal Button btnSearchDetail;
        internal DataGridView dgvDetail;
        private Label lblDetailTable;

        private Panel pnlProductTable;
        private Panel pnlSearchProduct;
        internal TextBox txtSearchProduct;
        internal Button btnSearchProduct;
        internal DataGridView dgvProducts;
        private Label lblProductTable;

        // Columns for dgvDetail
        private DataGridViewTextBoxColumn colDetailId;
        private DataGridViewTextBoxColumn colDetailVoucherId;
        private DataGridViewTextBoxColumn colDetailProductId;
        private DataGridViewTextBoxColumn colDetailProductName;
        private DataGridViewTextBoxColumn colDetailQty;
        private DataGridViewTextBoxColumn colDetailUnitPrice;
        private DataGridViewTextBoxColumn colDetailType;
        private DataGridViewTextBoxColumn colDetailCreatedAt;

        // Columns for dgvProducts
        private DataGridViewTextBoxColumn colProdId;
        private DataGridViewTextBoxColumn colProdName;
        private DataGridViewTextBoxColumn colProdUnit;
        private DataGridViewTextBoxColumn colProdPrice;
        private DataGridViewTextBoxColumn colProdStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            // Instantiate controls
            this.pnlInput = new Panel();
            this.lblVoucherCode = new Label();
            this.txtVoucherCode = new TextBox();
            this.lblProductCode = new Label();
            this.txtProductCode = new TextBox();
            this.lblEmployeeName = new Label();
            this.txtEmployeeName = new TextBox();
            this.lblProductName = new Label();
            this.txtProductName = new TextBox();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            this.lblType = new Label();
            this.cboType = new ComboBox();
            this.lblUnitPrice = new Label();
            this.txtUnitPrice = new TextBox();

            this.actionPanel = new FlowLayoutPanel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnPrint = new Button();

            this.pnlRight = new Panel();

            this.pnlDetailTable = new Panel();
            this.pnlSearchDetail = new Panel();
            this.txtSearchDetail = new TextBox();
            this.btnSearchDetail = new Button();
            this.dgvDetail = new DataGridView();
            this.lblDetailTable = new Label();

            this.pnlProductTable = new Panel();
            this.pnlSearchProduct = new Panel();
            this.txtSearchProduct = new TextBox();
            this.btnSearchProduct = new Button();
            this.dgvProducts = new DataGridView();
            this.lblProductTable = new Label();

            // Columns detail
            this.colDetailId = new DataGridViewTextBoxColumn();
            this.colDetailVoucherId = new DataGridViewTextBoxColumn();
            this.colDetailProductId = new DataGridViewTextBoxColumn();
            this.colDetailProductName = new DataGridViewTextBoxColumn();
            this.colDetailQty = new DataGridViewTextBoxColumn();
            this.colDetailUnitPrice = new DataGridViewTextBoxColumn();
            this.colDetailType = new DataGridViewTextBoxColumn();
            this.colDetailCreatedAt = new DataGridViewTextBoxColumn();

            // Columns product
            this.colProdId = new DataGridViewTextBoxColumn();
            this.colProdName = new DataGridViewTextBoxColumn();
            this.colProdUnit = new DataGridViewTextBoxColumn();
            this.colProdPrice = new DataGridViewTextBoxColumn();
            this.colProdStock = new DataGridViewTextBoxColumn();

            // Layout and properties

            // pnlInput (left)
            this.pnlInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.pnlInput.BackColor = Color.White;
            this.pnlInput.BorderStyle = BorderStyle.None;
            this.pnlInput.Location = new Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new Size(380, 639);
            this.pnlInput.TabIndex = 0;

            // Voucher Code
            this.lblVoucherCode.Font = new Font("Segoe UI", 10F);
            this.lblVoucherCode.ForeColor = Color.Black;
            this.lblVoucherCode.Location = new Point(16, 10);
            this.lblVoucherCode.Size = new Size(120, 24);
            this.lblVoucherCode.Text = "Mã Phiếu:";

            this.txtVoucherCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtVoucherCode.Location = new Point(16, 40);
            this.txtVoucherCode.Size = new Size(344, 26);
            this.txtVoucherCode.BackColor = Color.White;
            this.txtVoucherCode.BorderStyle = BorderStyle.FixedSingle;
            this.txtVoucherCode.ForeColor = Color.Black;

            // Product Code
            this.lblProductCode.Font = new Font("Segoe UI", 10F);
            this.lblProductCode.ForeColor = Color.Black;
            this.lblProductCode.Location = new Point(16, 76);
            this.lblProductCode.Size = new Size(120, 24);
            this.lblProductCode.Text = "Mã Sản Phẩm:";

            this.txtProductCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtProductCode.Location = new Point(16, 106);
            this.txtProductCode.Size = new Size(344, 26);
            this.txtProductCode.BackColor = Color.White;
            this.txtProductCode.BorderStyle = BorderStyle.FixedSingle;
            this.txtProductCode.ForeColor = Color.Black;

            // Employee Name
            this.lblEmployeeName.Font = new Font("Segoe UI", 10F);
            this.lblEmployeeName.ForeColor = Color.Black;
            this.lblEmployeeName.Location = new Point(16, 142);
            this.lblEmployeeName.Size = new Size(120, 24);
            this.lblEmployeeName.Text = "Tên Nhân Viên:";

            this.txtEmployeeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtEmployeeName.Location = new Point(16, 172);
            this.txtEmployeeName.Size = new Size(344, 26);
            this.txtEmployeeName.BackColor = Color.White;
            this.txtEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmployeeName.ForeColor = Color.Black;

            // Product Name
            this.lblProductName.Font = new Font("Segoe UI", 10F);
            this.lblProductName.ForeColor = Color.Black;
            this.lblProductName.Location = new Point(16, 208);
            this.lblProductName.Size = new Size(120, 24);
            this.lblProductName.Text = "Tên Sản Phẩm:";

            this.txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtProductName.Location = new Point(16, 238);
            this.txtProductName.Size = new Size(344, 26);
            this.txtProductName.BackColor = Color.White;
            this.txtProductName.BorderStyle = BorderStyle.FixedSingle;
            this.txtProductName.ForeColor = Color.Black;

            // Date
            this.lblDate.Font = new Font("Segoe UI", 10F);
            this.lblDate.ForeColor = Color.Black;
            this.lblDate.Location = new Point(16, 274);
            this.lblDate.Size = new Size(120, 24);
            this.lblDate.Text = "Ngày Thực Hiện:";

            this.dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(16, 304);
            this.dtpDate.Size = new Size(344, 27);

            // Quantity
            this.lblQuantity.Font = new Font("Segoe UI", 10F);
            this.lblQuantity.ForeColor = Color.Black;
            this.lblQuantity.Location = new Point(16, 340);
            this.lblQuantity.Size = new Size(120, 24);
            this.lblQuantity.Text = "Số lượng:";

            this.txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtQuantity.Location = new Point(16, 370);
            this.txtQuantity.Size = new Size(344, 26);
            this.txtQuantity.BackColor = Color.White;
            this.txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            this.txtQuantity.ForeColor = Color.Black;

            // Type
            this.lblType.Font = new Font("Segoe UI", 10F);
            this.lblType.ForeColor = Color.Black;
            this.lblType.Location = new Point(16, 406);
            this.lblType.Size = new Size(120, 24);
            this.lblType.Text = "Loại:";

            this.cboType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboType.Location = new Point(16, 436);
            this.cboType.Size = new Size(344, 28);
            this.cboType.BackColor = Color.White;
            this.cboType.ForeColor = Color.Black;
            // items can be populated in code-behind: "Nhập", "Xuất"

            // Unit Price
            this.lblUnitPrice.Font = new Font("Segoe UI", 10F);
            this.lblUnitPrice.ForeColor = Color.Black;
            this.lblUnitPrice.Location = new Point(16, 472);
            this.lblUnitPrice.Size = new Size(120, 24);
            this.lblUnitPrice.Text = "Đơn Giá:";

            this.txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtUnitPrice.Location = new Point(16, 502);
            this.txtUnitPrice.Size = new Size(344, 26);
            this.txtUnitPrice.BackColor = Color.White;
            this.txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            this.txtUnitPrice.ForeColor = Color.Black;

            // actionPanel (buttons)
            this.actionPanel.FlowDirection = FlowDirection.LeftToRight;
            this.actionPanel.Location = new Point(16, 540);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new Size(344, 40);
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Controls.Add(this.btnEdit);
            this.actionPanel.Controls.Add(this.btnDelete);
            this.actionPanel.Controls.Add(this.btnPrint);

            // btnAdd
            this.btnAdd.Text = "Thêm";
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.System;
            this.btnAdd.ForeColor = Color.Black;
            this.btnAdd.Name = "btnAdd";

            // btnEdit
            this.btnEdit.Text = "Sửa";
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.System;
            this.btnEdit.ForeColor = Color.Black;
            this.btnEdit.Name = "btnEdit";

            // btnDelete
            this.btnDelete.Text = "Xóa";
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.System;
            this.btnDelete.ForeColor = Color.Black;
            this.btnDelete.Name = "btnDelete";

            // btnPrint
            this.btnPrint.Text = "In";
            this.btnPrint.AutoSize = true;
            this.btnPrint.BackColor = Color.White;
            this.btnPrint.FlatStyle = FlatStyle.System;
            this.btnPrint.ForeColor = Color.Black;
            this.btnPrint.Name = "btnPrint";

            // Add controls to pnlInput
            this.pnlInput.Controls.Add(this.lblVoucherCode);
            this.pnlInput.Controls.Add(this.txtVoucherCode);
            this.pnlInput.Controls.Add(this.lblProductCode);
            this.pnlInput.Controls.Add(this.txtProductCode);
            this.pnlInput.Controls.Add(this.lblEmployeeName);
            this.pnlInput.Controls.Add(this.txtEmployeeName);
            this.pnlInput.Controls.Add(this.lblProductName);
            this.pnlInput.Controls.Add(this.txtProductName);
            this.pnlInput.Controls.Add(this.lblDate);
            this.pnlInput.Controls.Add(this.dtpDate);
            this.pnlInput.Controls.Add(this.lblQuantity);
            this.pnlInput.Controls.Add(this.txtQuantity);
            this.pnlInput.Controls.Add(this.lblType);
            this.pnlInput.Controls.Add(this.cboType);
            this.pnlInput.Controls.Add(this.lblUnitPrice);
            this.pnlInput.Controls.Add(this.txtUnitPrice);
            this.pnlInput.Controls.Add(this.actionPanel);

            // Right panel (contains two stacked tables)
            this.pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlRight.BackColor = Color.White;
            this.pnlRight.BorderStyle = BorderStyle.None;
            this.pnlRight.Location = new Point(408, 12);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new Size(1184, 639);
            this.pnlRight.TabIndex = 1;

            // Detail table area
            this.pnlDetailTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlDetailTable.BackColor = Color.White;
            this.pnlDetailTable.BorderStyle = BorderStyle.None;
            this.pnlDetailTable.Location = new Point(10, 10);
            this.pnlDetailTable.Name = "pnlDetailTable";
            this.pnlDetailTable.Size = new Size(1164, 310);

            // Search detail
            this.pnlSearchDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlSearchDetail.BackColor = Color.White;
            this.pnlSearchDetail.BorderStyle = BorderStyle.None;
            this.pnlSearchDetail.Location = new Point(10, 10);
            this.pnlSearchDetail.Size = new Size(1144, 36);
            this.pnlSearchDetail.Controls.Add(this.txtSearchDetail);
            this.pnlSearchDetail.Controls.Add(this.btnSearchDetail);

            this.txtSearchDetail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtSearchDetail.Location = new Point(6, 6);
            this.txtSearchDetail.Size = new Size(1054, 26);
            this.txtSearchDetail.BackColor = Color.White;
            this.txtSearchDetail.ForeColor = Color.Gray;
            this.txtSearchDetail.Text = "Tìm kiếm chi tiết...";

            this.btnSearchDetail.Anchor = AnchorStyles.Right;
            this.btnSearchDetail.Location = new Point(1066, 4);
            this.btnSearchDetail.Size = new Size(64, 27);
            this.btnSearchDetail.Text = "Tìm kiếm";
            this.btnSearchDetail.BackColor = Color.White;
            this.btnSearchDetail.FlatStyle = FlatStyle.System;
            this.btnSearchDetail.ForeColor = Color.Black;

            // Detail label
            this.lblDetailTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDetailTable.ForeColor = Color.Black;
            this.lblDetailTable.Location = new Point(0, 56);
            this.lblDetailTable.Size = new Size(392, 28);
            this.lblDetailTable.Text = "Bảng chi tiết phiếu nhập/xuất";
            this.lblDetailTable.TextAlign = ContentAlignment.MiddleLeft;

            // dgvDetail
            this.dgvDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvDetail.Location = new Point(10, 87);
            this.dgvDetail.Size = new Size(1144, 210);
            this.dgvDetail.BackgroundColor = Color.White;
            this.dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.White;
            headerStyle.ForeColor = Color.Black;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.False;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDetail.ColumnHeadersHeight = 34;
            this.dgvDetail.EnableHeadersVisualStyles = true;
            this.dgvDetail.GridColor = Color.LightGray;
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 62;
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            this.dgvDetail.RowTemplate.DefaultCellStyle = rowStyle;
            this.dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add columns to dgvDetail
            this.colDetailId.HeaderText = "Detail ID";
            this.colDetailId.Name = "colDetailId";
            this.colDetailId.ReadOnly = true;

            this.colDetailVoucherId.HeaderText = "Mã Phiếu";
            this.colDetailVoucherId.Name = "colDetailVoucherId";
            this.colDetailVoucherId.ReadOnly = true;

            this.colDetailProductId.HeaderText = "Mã SP";
            this.colDetailProductId.Name = "colDetailProductId";
            this.colDetailProductId.ReadOnly = true;

            this.colDetailProductName.HeaderText = "Tên SP";
            this.colDetailProductName.Name = "colDetailProductName";
            this.colDetailProductName.ReadOnly = true;

            this.colDetailQty.HeaderText = "Số lượng";
            this.colDetailQty.Name = "colDetailQty";
            this.colDetailQty.ReadOnly = true;

            this.colDetailUnitPrice.HeaderText = "Đơn giá";
            this.colDetailUnitPrice.Name = "colDetailUnitPrice";
            this.colDetailUnitPrice.ReadOnly = true;

            this.colDetailType.HeaderText = "Loại";
            this.colDetailType.Name = "colDetailType";
            this.colDetailType.ReadOnly = true;

            this.colDetailCreatedAt.HeaderText = "Ngày tạo";
            this.colDetailCreatedAt.Name = "colDetailCreatedAt";
            this.colDetailCreatedAt.ReadOnly = true;

            this.dgvDetail.Columns.AddRange(new DataGridViewColumn[] {
                this.colDetailId,
                this.colDetailVoucherId,
                this.colDetailProductId,
                this.colDetailProductName,
                this.colDetailQty,
                this.colDetailUnitPrice,
                this.colDetailType,
                this.colDetailCreatedAt
            });

            // Add search + label + grid to pnlDetailTable
            this.pnlDetailTable.Controls.Add(this.pnlSearchDetail);
            this.pnlDetailTable.Controls.Add(this.lblDetailTable);
            this.pnlDetailTable.Controls.Add(this.dgvDetail);

            // Product table area (below detail)
            this.pnlProductTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlProductTable.BackColor = Color.White;
            this.pnlProductTable.BorderStyle = BorderStyle.None;
            this.pnlProductTable.Location = new Point(10, 330);
            this.pnlProductTable.Name = "pnlProductTable";
            this.pnlProductTable.Size = new Size(1164, 299);

            // Search product
            this.pnlSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlSearchProduct.BackColor = Color.White;
            this.pnlSearchProduct.BorderStyle = BorderStyle.None;
            this.pnlSearchProduct.Location = new Point(10, 10);
            this.pnlSearchProduct.Size = new Size(1144, 36);
            this.pnlSearchProduct.Controls.Add(this.txtSearchProduct);
            this.pnlSearchProduct.Controls.Add(this.btnSearchProduct);

            this.txtSearchProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtSearchProduct.Location = new Point(6, 6);
            this.txtSearchProduct.Size = new Size(1054, 26);
            this.txtSearchProduct.BackColor = Color.White;
            this.txtSearchProduct.ForeColor = Color.Gray;
            this.txtSearchProduct.Text = "Tìm kiếm sản phẩm...";

            this.btnSearchProduct.Anchor = AnchorStyles.Right;
            this.btnSearchProduct.Location = new Point(1066, 4);
            this.btnSearchProduct.Size = new Size(64, 27);
            this.btnSearchProduct.Text = "Tìm kiếm";
            this.btnSearchProduct.BackColor = Color.White;
            this.btnSearchProduct.FlatStyle = FlatStyle.System;
            this.btnSearchProduct.ForeColor = Color.Black;

            // Product label
            this.lblProductTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblProductTable.ForeColor = Color.Black;
            this.lblProductTable.Location = new Point(0, 56);
            this.lblProductTable.Size = new Size(392, 28);
            this.lblProductTable.Text = "Bảng sản phẩm";
            this.lblProductTable.TextAlign = ContentAlignment.MiddleLeft;

            // dgvProducts
            this.dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvProducts.Location = new Point(10, 87);
            this.dgvProducts.Size = new Size(1144, 200);
            this.dgvProducts.BackgroundColor = Color.White;
            this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvProducts.ColumnHeadersHeight = 34;
            this.dgvProducts.EnableHeadersVisualStyles = true;
            this.dgvProducts.GridColor = Color.LightGray;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.DefaultCellStyle = rowStyle;
            this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add columns to dgvProducts
            this.colProdId.HeaderText = "Product ID";
            this.colProdId.Name = "colProdId";
            this.colProdId.ReadOnly = true;

            this.colProdName.HeaderText = "Name";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;

            this.colProdUnit.HeaderText = "Đơn vị";
            this.colProdUnit.Name = "colProdUnit";
            this.colProdUnit.ReadOnly = true;

            this.colProdPrice.HeaderText = "Giá";
            this.colProdPrice.Name = "colProdPrice";
            this.colProdPrice.ReadOnly = true;

            this.colProdStock.HeaderText = "Tồn kho";
            this.colProdStock.Name = "colProdStock";
            this.colProdStock.ReadOnly = true;

            this.dgvProducts.Columns.AddRange(new DataGridViewColumn[] {
                this.colProdId,
                this.colProdName,
                this.colProdUnit,
                this.colProdPrice,
                this.colProdStock
            });

            // Add search + label + grid to pnlProductTable
            this.pnlProductTable.Controls.Add(this.pnlSearchProduct);
            this.pnlProductTable.Controls.Add(this.lblProductTable);
            this.pnlProductTable.Controls.Add(this.dgvProducts);

            // Add detail and product panels to right panel
            this.pnlRight.Controls.Add(this.pnlDetailTable);
            this.pnlRight.Controls.Add(this.pnlProductTable);

            // FormStockDetail
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlRight);
            this.ForeColor = Color.Black;
            this.MinimumSize = new Size(760, 480);
            this.Name = "FormStockDetail";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Chi tiết phiếu nhập/xuất";

            // Finalize layout
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlDetailTable.ResumeLayout(false);
            this.pnlSearchDetail.ResumeLayout(false);
            this.pnlSearchDetail.PerformLayout();
            ((ISupportInitialize)(this.dgvDetail)).EndInit();
            this.pnlProductTable.ResumeLayout(false);
            this.pnlSearchProduct.ResumeLayout(false);
            this.pnlSearchProduct.PerformLayout();
            ((ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}