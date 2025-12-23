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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblVoucherId = new System.Windows.Forms.Label();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.colVoucherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.White;
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
            this.pnlInput.Location = new System.Drawing.Point(8, 8);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(253, 426);
            this.pnlInput.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(11, 7);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Loại:";
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.BackColor = System.Drawing.Color.White;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.ForeColor = System.Drawing.Color.Black;
            this.cboType.Location = new System.Drawing.Point(11, 27);
            this.cboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(231, 21);
            this.cboType.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(11, 53);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Ngày Thực Hiện:";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(11, 73);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(231, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVoucherId.ForeColor = System.Drawing.Color.Black;
            this.lblVoucherId.Location = new System.Drawing.Point(11, 100);
            this.lblVoucherId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(80, 16);
            this.lblVoucherId.TabIndex = 4;
            this.lblVoucherId.Text = "ID Phiếu:";
            // 
            // txtVoucherId
            // 
            this.txtVoucherId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVoucherId.BackColor = System.Drawing.Color.White;
            this.txtVoucherId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherId.ForeColor = System.Drawing.Color.Black;
            this.txtVoucherId.Location = new System.Drawing.Point(11, 120);
            this.txtVoucherId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.Size = new System.Drawing.Size(230, 20);
            this.txtVoucherId.TabIndex = 5;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblEmployee.Location = new System.Drawing.Point(11, 147);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(80, 16);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân viên:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmployee.BackColor = System.Drawing.Color.White;
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.ForeColor = System.Drawing.Color.Black;
            this.cboEmployee.Location = new System.Drawing.Point(11, 167);
            this.cboEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(231, 21);
            this.cboEmployee.TabIndex = 7;
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(11, 193);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(80, 16);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.Location = new System.Drawing.Point(11, 213);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(230, 107);
            this.txtNote.TabIndex = 9;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Controls.Add(this.btnEdit);
            this.actionPanel.Controls.Add(this.btnDelete);
            this.actionPanel.Controls.Add(this.btnViewDetail);
            this.actionPanel.Location = new System.Drawing.Point(11, 333);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(229, 61);
            this.actionPanel.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 22);
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
            this.btnEdit.Location = new System.Drawing.Point(56, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 22);
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
            this.btnDelete.Location = new System.Drawing.Point(110, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 22);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.AutoSize = true;
            this.btnViewDetail.BackColor = System.Drawing.Color.White;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewDetail.ForeColor = System.Drawing.Color.Black;
            this.btnViewDetail.Location = new System.Drawing.Point(2, 28);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(81, 22);
            this.btnViewDetail.TabIndex = 3;
            this.btnViewDetail.Text = "Xem Chi Tiết";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Controls.Add(this.lblTableTitle);
            this.pnlTable.Controls.Add(this.dgvVouchers);
            this.pnlTable.Controls.Add(this.pnlSearch);
            this.pnlTable.Location = new System.Drawing.Point(272, 8);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(789, 426);
            this.pnlTable.TabIndex = 1;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTableTitle.Location = new System.Drawing.Point(0, 37);
            this.lblTableTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(261, 19);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "Bảng Phiếu nhập/xuất";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVouchers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVouchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVouchers.ColumnHeadersHeight = 34;
            this.dgvVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherId,
            this.colType,
            this.colDate,
            this.colEmployee,
            this.colNote,
            this.colTotalItems,
            this.colCreatedAt});
            this.dgvVouchers.GridColor = System.Drawing.Color.LightGray;
            this.dgvVouchers.Location = new System.Drawing.Point(7, 58);
            this.dgvVouchers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 62;
            this.dgvVouchers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVouchers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvVouchers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVouchers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(775, 359);
            this.dgvVouchers.TabIndex = 1;
            // 
            // colVoucherId
            // 
            this.colVoucherId.DataPropertyName = "VoucherId";
            this.colVoucherId.HeaderText = "ID Phiếu";
            this.colVoucherId.Name = "colVoucherId";
            this.colVoucherId.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Loại";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Ngày";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colEmployee
            // 
            this.colEmployee.DataPropertyName = "Employee";
            this.colEmployee.HeaderText = "Nhân viên";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            // 
            // colNote
            // 
            this.colNote.DataPropertyName = "Note";
            this.colNote.HeaderText = "Ghi chú";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            // 
            // colTotalItems
            // 
            this.colTotalItems.DataPropertyName = "TotalItems";
            this.colTotalItems.HeaderText = "Tổng SL";
            this.colTotalItems.Name = "colTotalItems";
            this.colTotalItems.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.DataPropertyName = "CreatedAt";
            this.colCreatedAt.HeaderText = "Ngày tạo";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(7, 7);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(775, 24);
            this.pnlSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(4, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(722, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm kiếm phiếu...";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(729, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 18);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 442);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(512, 333);
            this.Name = "Form_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Phiếu nhập/xuất";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}