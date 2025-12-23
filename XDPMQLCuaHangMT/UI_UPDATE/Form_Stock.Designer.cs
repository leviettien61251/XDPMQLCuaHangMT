// FormImportExport.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.UI_UPDATE
{
    partial class Form_Stock
    {
        private IContainer components = null;

        private Panel pnlInput;
        private Label lblType;
        internal ComboBox cboType;
        private Label lblDate;
        internal DateTimePicker dtpDate;
        private Label lblVoucherId;
        internal TextBox txtVoucherId;
        private Label lblEmployee;
        internal ComboBox cboEmployee;
        private Label lblNote;
        internal TextBox txtNote;
        private FlowLayoutPanel actionPanel;
        internal Button btnAdd;
        internal Button btnEdit;
        internal Button btnDelete;
        internal Button btnViewDetail;

        private Panel pnlTable;
        private Panel pnlSearch;
        internal TextBox txtSearch;
        internal Button btnSearch;
        internal DataGridView dgvVouchers;
        private Label lblTableTitle;

        private DataGridViewTextBoxColumn colVoucherId;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colEmployee;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colTotalItems;
        private DataGridViewTextBoxColumn colCreatedAt;

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

            this.pnlInput = new Panel();
            this.lblType = new Label();
            this.cboType = new ComboBox();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblVoucherId = new Label();
            this.txtVoucherId = new TextBox();
            this.lblEmployee = new Label();
            this.cboEmployee = new ComboBox();
            this.lblNote = new Label();
            this.txtNote = new TextBox();
            this.actionPanel = new FlowLayoutPanel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnViewDetail = new Button();

            this.pnlTable = new Panel();
            this.pnlSearch = new Panel();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.dgvVouchers = new DataGridView();
            this.lblTableTitle = new Label();

            this.colVoucherId = new DataGridViewTextBoxColumn();
            this.colType = new DataGridViewTextBoxColumn();
            this.colDate = new DataGridViewTextBoxColumn();
            this.colEmployee = new DataGridViewTextBoxColumn();
            this.colNote = new DataGridViewTextBoxColumn();
            this.colTotalItems = new DataGridViewTextBoxColumn();
            this.colCreatedAt = new DataGridViewTextBoxColumn();

            this.pnlInput.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.SuspendLayout();

            // pnlInput
            this.pnlInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.pnlInput.BackColor = Color.White;
            this.pnlInput.BorderStyle = BorderStyle.None;
            this.pnlInput.Controls.Add(this.lblType);
            this.pnlInput.Controls.Add(this.cboType);
            this.pnlInput.Controls.Add(this.lblDate);
            this.pnlInput.Controls.Add(this.dtpDate);
            this.pnlInput.Controls.Add(this.lblVoucherId);
            this.pnlInput.Controls.Add(this.txtVoucherId);
            this.pnlInput.Controls.Add(this.lblEmployee);
            this.pnlInput.Controls.Add(this.cboEmployee);
            this.pnlInput.Controls.Add(this.lblNote);
            this.pnlInput.Controls.Add(this.txtNote);
            this.pnlInput.Controls.Add(this.actionPanel);
            this.pnlInput.Location = new Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new Size(380, 639);
            this.pnlInput.TabIndex = 0;

            // lblType
            this.lblType.Font = new Font("Segoe UI", 10F);
            this.lblType.ForeColor = Color.Black;
            this.lblType.Location = new Point(16, 10);
            this.lblType.Name = "lblType";
            this.lblType.Size = new Size(120, 24);
            this.lblType.Text = "Loại:";

            // cboType
            this.cboType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboType.BackColor = Color.White;
            this.cboType.ForeColor = Color.Black;
            this.cboType.Location = new Point(16, 40);
            this.cboType.Name = "cboType";
            this.cboType.Size = new Size(344, 28);

            // lblDate
            this.lblDate.Font = new Font("Segoe UI", 10F);
            this.lblDate.ForeColor = Color.Black;
            this.lblDate.Location = new Point(16, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(160, 24);
            this.lblDate.Text = "Ngày Thực Hiện:";

            // dtpDate
            this.dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(16, 110);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(344, 27);

            // lblVoucherId
            this.lblVoucherId.Font = new Font("Segoe UI", 10F);
            this.lblVoucherId.ForeColor = Color.Black;
            this.lblVoucherId.Location = new Point(16, 150);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new Size(120, 24);
            this.lblVoucherId.Text = "ID Phiếu:";

            // txtVoucherId
            this.txtVoucherId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtVoucherId.BackColor = Color.White;
            this.txtVoucherId.BorderStyle = BorderStyle.FixedSingle;
            this.txtVoucherId.ForeColor = Color.Black;
            this.txtVoucherId.Location = new Point(16, 180);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.Size = new Size(344, 26);

            // lblEmployee
            this.lblEmployee.Font = new Font("Segoe UI", 10F);
            this.lblEmployee.ForeColor = Color.Black;
            this.lblEmployee.Location = new Point(16, 220);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new Size(120, 24);
            this.lblEmployee.Text = "Nhân viên:";

            // cboEmployee
            this.cboEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboEmployee.BackColor = Color.White;
            this.cboEmployee.ForeColor = Color.Black;
            this.cboEmployee.Location = new Point(16, 250);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new Size(344, 28);

            // lblNote
            this.lblNote.Font = new Font("Segoe UI", 10F);
            this.lblNote.ForeColor = Color.Black;
            this.lblNote.Location = new Point(16, 290);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new Size(120, 24);
            this.lblNote.Text = "Ghi chú:";

            // txtNote
            this.txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtNote.BackColor = Color.White;
            this.txtNote.BorderStyle = BorderStyle.FixedSingle;
            this.txtNote.ForeColor = Color.Black;
            this.txtNote.Location = new Point(16, 320);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new Size(344, 160);

            // actionPanel
            this.actionPanel.FlowDirection = FlowDirection.LeftToRight;
            this.actionPanel.Location = new Point(16, 500);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new Size(344, 40);
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Controls.Add(this.btnEdit);
            this.actionPanel.Controls.Add(this.btnDelete);
            this.actionPanel.Controls.Add(this.btnViewDetail);

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

            // btnViewDetail
            this.btnViewDetail.Text = "Xem Chi Tiết";
            this.btnViewDetail.AutoSize = true;
            this.btnViewDetail.BackColor = Color.White;
            this.btnViewDetail.FlatStyle = FlatStyle.System;
            this.btnViewDetail.ForeColor = Color.Black;
            this.btnViewDetail.Name = "btnViewDetail";

            // pnlTable
            this.pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlTable.BackColor = Color.White;
            this.pnlTable.BorderStyle = BorderStyle.None;
            this.pnlTable.Controls.Add(this.lblTableTitle);
            this.pnlTable.Controls.Add(this.dgvVouchers);
            this.pnlTable.Controls.Add(this.pnlSearch);
            this.pnlTable.Location = new Point(408, 12);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new Size(1184, 639);
            this.pnlTable.TabIndex = 1;

            // pnlSearch
            this.pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlSearch.BackColor = Color.White;
            this.pnlSearch.BorderStyle = BorderStyle.None;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new Point(10, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new Size(1162, 36);
            this.pnlSearch.TabIndex = 3;

            // txtSearch
            this.txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtSearch.BackColor = Color.White;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.Location = new Point(6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(1082, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm kiếm phiếu...";

            // btnSearch
            this.btnSearch.Anchor = AnchorStyles.Right;
            this.btnSearch.BackColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.System;
            this.btnSearch.ForeColor = Color.Black;
            this.btnSearch.Location = new Point(1094, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(64, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;

            // lblTableTitle
            this.lblTableTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTableTitle.ForeColor = Color.Black;
            this.lblTableTitle.Location = new Point(0, 56);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new Size(392, 28);
            this.lblTableTitle.Text = "Bảng Phiếu nhập/xuất";
            this.lblTableTitle.TextAlign = ContentAlignment.MiddleLeft;

            // dgvVouchers
            this.dgvVouchers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvVouchers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVouchers.BackgroundColor = Color.White;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.White;
            headerStyle.ForeColor = Color.Black;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.False;
            this.dgvVouchers.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvVouchers.ColumnHeadersHeight = 34;
            this.dgvVouchers.EnableHeadersVisualStyles = true;
            this.dgvVouchers.GridColor = Color.LightGray;
            this.dgvVouchers.Location = new Point(10, 87);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 62;
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            rowStyle.SelectionBackColor = SystemColors.Highlight;
            rowStyle.SelectionForeColor = SystemColors.HighlightText;
            rowStyle.WrapMode = DataGridViewTriState.False;
            this.dgvVouchers.RowTemplate.DefaultCellStyle = rowStyle;
            this.dgvVouchers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new Size(1162, 538);
            this.dgvVouchers.TabIndex = 1;

            // Columns
            this.colVoucherId.DataPropertyName = "VoucherId";
            this.colVoucherId.HeaderText = "ID Phiếu";
            this.colVoucherId.Name = "colVoucherId";
            this.colVoucherId.ReadOnly = true;

            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Loại";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;

            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Ngày";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;

            this.colEmployee.DataPropertyName = "Employee";
            this.colEmployee.HeaderText = "Nhân viên";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;

            this.colNote.DataPropertyName = "Note";
            this.colNote.HeaderText = "Ghi chú";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;

            this.colTotalItems.DataPropertyName = "TotalItems";
            this.colTotalItems.HeaderText = "Tổng SL";
            this.colTotalItems.Name = "colTotalItems";
            this.colTotalItems.ReadOnly = true;

            this.colCreatedAt.DataPropertyName = "CreatedAt";
            this.colCreatedAt.HeaderText = "Ngày tạo";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;

            this.dgvVouchers.Columns.AddRange(new DataGridViewColumn[] {
                this.colVoucherId,
                this.colType,
                this.colDate,
                this.colEmployee,
                this.colNote,
                this.colTotalItems,
                this.colCreatedAt
            });

            // FormImportExport
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTable);
            this.ForeColor = Color.Black;
            this.MinimumSize = new Size(760, 480);
            this.Name = "FormImportExport";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Phiếu nhập/xuất";

            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}