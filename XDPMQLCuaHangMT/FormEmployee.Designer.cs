using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class FormEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonImageURL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pnlBangNhanVien = new System.Windows.Forms.Panel();
            this.lblBangNhanVien = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDeletedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeletedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTimKiemNV = new System.Windows.Forms.Panel();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBangNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlTimKiemNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.pictureBox1);
            this.pnlInput.Controls.Add(this.buttonImageURL);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.textBoxLastName);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.textBoxFirstName);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.textBoxPhone);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.textBoxEmail);
            this.pnlInput.Controls.Add(this.buttonAdd);
            this.pnlInput.Controls.Add(this.buttonUpdate);
            this.pnlInput.Controls.Add(this.buttonDelete);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(380, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonImageURL
            // 
            this.buttonImageURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonImageURL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonImageURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImageURL.ForeColor = System.Drawing.Color.White;
            this.buttonImageURL.Location = new System.Drawing.Point(24, 184);
            this.buttonImageURL.Name = "buttonImageURL";
            this.buttonImageURL.Size = new System.Drawing.Size(120, 30);
            this.buttonImageURL.TabIndex = 1;
            this.buttonImageURL.Text = "Thêm ảnh";
            this.buttonImageURL.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.ForeColor = System.Drawing.Color.White;
            this.textBoxLastName.Location = new System.Drawing.Point(200, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(160, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.ForeColor = System.Drawing.Color.White;
            this.textBoxFirstName.Location = new System.Drawing.Point(200, 112);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(160, 26);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.Location = new System.Drawing.Point(16, 268);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(344, 26);
            this.textBoxPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(16, 334);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(344, 26);
            this.textBoxEmail.TabIndex = 9;
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
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // pnlBangNhanVien
            // 
            this.pnlBangNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBangNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlBangNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBangNhanVien.Controls.Add(this.lblBangNhanVien);
            this.pnlBangNhanVien.Controls.Add(this.dgvEmployees);
            this.pnlBangNhanVien.Controls.Add(this.pnlTimKiemNV);
            this.pnlBangNhanVien.Location = new System.Drawing.Point(408, 12);
            this.pnlBangNhanVien.Name = "pnlBangNhanVien";
            this.pnlBangNhanVien.Size = new System.Drawing.Size(1184, 639);
            this.pnlBangNhanVien.TabIndex = 1;
            // 
            // lblBangNhanVien
            // 
            this.lblBangNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBangNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBangNhanVien.Location = new System.Drawing.Point(0, 56);
            this.lblBangNhanVien.Name = "lblBangNhanVien";
            this.lblBangNhanVien.Size = new System.Drawing.Size(392, 28);
            this.lblBangNhanVien.TabIndex = 0;
            this.lblBangNhanVien.Text = "Bảng nhân viên";
            this.lblBangNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeight = 34;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colFirstName,
            this.colLastName,
            this.colImageUrl,
            this.colPhone,
            this.colEmail,
            this.colIsActive,
            this.colDeletedAt,
            this.colDeletedBy});
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvEmployees.Location = new System.Drawing.Point(10, 87);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvEmployees.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1162, 538);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            this.colEmployeeId.HeaderText = "Employee ID";
            this.colEmployeeId.MinimumWidth = 8;
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 8;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 8;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colImageUrl
            // 
            this.colImageUrl.DataPropertyName = "ImageUrl";
            this.colImageUrl.HeaderText = "Image URL";
            this.colImageUrl.MinimumWidth = 8;
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.ReadOnly = true;
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
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 8;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // colDeletedAt
            // 
            this.colDeletedAt.DataPropertyName = "DeletedAt";
            this.colDeletedAt.HeaderText = "Deleted At";
            this.colDeletedAt.MinimumWidth = 8;
            this.colDeletedAt.Name = "colDeletedAt";
            this.colDeletedAt.ReadOnly = true;
            // 
            // colDeletedBy
            // 
            this.colDeletedBy.DataPropertyName = "DeletedBy";
            this.colDeletedBy.HeaderText = "Deleted By";
            this.colDeletedBy.MinimumWidth = 8;
            this.colDeletedBy.Name = "colDeletedBy";
            this.colDeletedBy.ReadOnly = true;
            // 
            // pnlTimKiemNV
            // 
            this.pnlTimKiemNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimKiemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlTimKiemNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiemNV.Controls.Add(this.txtTimKiemNV);
            this.pnlTimKiemNV.Controls.Add(this.btnTimKiemNV);
            this.pnlTimKiemNV.Location = new System.Drawing.Point(10, 10);
            this.pnlTimKiemNV.Name = "pnlTimKiemNV";
            this.pnlTimKiemNV.Size = new System.Drawing.Size(1162, 36);
            this.pnlTimKiemNV.TabIndex = 3;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtTimKiemNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemNV.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemNV.Location = new System.Drawing.Point(6, 6);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(1082, 26);
            this.txtTimKiemNV.TabIndex = 0;
            this.txtTimKiemNV.Text = "Tìm kiếm nhân viên...";
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimKiemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTimKiemNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimKiemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNV.Location = new System.Drawing.Point(1094, 4);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(64, 27);
            this.btnTimKiemNV.TabIndex = 1;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1604, 663);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlBangNhanVien);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhân Viên";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBangNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlTimKiemNV.ResumeLayout(false);
            this.pnlTimKiemNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Controls
        private Panel pnlInput;
        private PictureBox pictureBox1;
        private Button buttonImageURL;
        private Label label1;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxFirstName;
        private Label label3;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxEmail;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Panel pnlBangNhanVien;
        private Label lblBangNhanVien;
        private Panel pnlTimKiemNV;
        private TextBox txtTimKiemNV;
        private Button btnTimKiemNV;
        private DataGridView dgvEmployees;

        // DataGridView columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeletedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeletedBy;
    }
}