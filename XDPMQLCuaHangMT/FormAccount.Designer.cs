using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormAccount : Form
    {
        // Designer-generated InitializeComponent only; keep constructor in FormAccount.cs

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlBangTaiKhoan = new System.Windows.Forms.Panel();
            this.lblBangTaiKhoan = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPasswordHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTimKiemTK = new System.Windows.Forms.Panel();
            this.txtTimKiemTK = new System.Windows.Forms.TextBox();
            this.btnTimKiemTK = new System.Windows.Forms.Button();
            this.pnlBangNhanVien = new System.Windows.Forms.Panel();
            this.lblBangNhanVien = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeletedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeletedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTimKiemNV = new System.Windows.Forms.Panel();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.pnlBangTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.pnlTimKiemTK.SuspendLayout();
            this.pnlBangNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlTimKiemNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lblTenDangNhap);
            this.pnlInput.Controls.Add(this.txtTenDangNhap);
            this.pnlInput.Controls.Add(this.lblMatKhau);
            this.pnlInput.Controls.Add(this.txtMatKhau);
            this.pnlInput.Controls.Add(this.lblChucVu);
            this.pnlInput.Controls.Add(this.cboChucVu);
            this.pnlInput.Controls.Add(this.lblNhanVien);
            this.pnlInput.Controls.Add(this.cboNhanVien);
            this.pnlInput.Controls.Add(this.textBoxEmployee);
            this.pnlInput.Controls.Add(this.btnThem);
            this.pnlInput.Controls.Add(this.btnSua);
            this.pnlInput.Controls.Add(this.btnXoa);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(360, 639);
            this.pnlInput.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblTenDangNhap.Location = new System.Drawing.Point(10, 10);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(120, 24);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.txtTenDangNhap.Location = new System.Drawing.Point(10, 40);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(330, 26);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblMatKhau.Location = new System.Drawing.Point(10, 78);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(120, 24);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Location = new System.Drawing.Point(10, 108);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(330, 26);
            this.txtMatKhau.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(10, 146);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(120, 24);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.ForeColor = System.Drawing.Color.White;
            this.cboChucVu.Items.AddRange(new object[] {
            "Admin",
            "Quản lý",
            "Nhân viên"});
            this.cboChucVu.Location = new System.Drawing.Point(10, 176);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(330, 28);
            this.cboChucVu.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblNhanVien.Location = new System.Drawing.Point(10, 214);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(120, 24);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.ForeColor = System.Drawing.Color.White;
            this.cboNhanVien.Location = new System.Drawing.Point(10, 244);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(330, 28);
            this.cboNhanVien.TabIndex = 7;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployee.ForeColor = System.Drawing.Color.White;
            this.textBoxEmployee.Location = new System.Drawing.Point(10, 280);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(330, 26);
            this.textBoxEmployee.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 439);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(110, 439);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(210, 439);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // pnlBangTaiKhoan
            // 
            this.pnlBangTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBangTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlBangTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBangTaiKhoan.Controls.Add(this.lblBangTaiKhoan);
            this.pnlBangTaiKhoan.Controls.Add(this.dgvTaiKhoan);
            this.pnlBangTaiKhoan.Controls.Add(this.pnlTimKiemTK);
            this.pnlBangTaiKhoan.Location = new System.Drawing.Point(388, 12);
            this.pnlBangTaiKhoan.Name = "pnlBangTaiKhoan";
            this.pnlBangTaiKhoan.Size = new System.Drawing.Size(1207, 260);
            this.pnlBangTaiKhoan.TabIndex = 1;
            // 
            // lblBangTaiKhoan
            // 
            this.lblBangTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBangTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblBangTaiKhoan.Location = new System.Drawing.Point(0, 56);
            this.lblBangTaiKhoan.Name = "lblBangTaiKhoan";
            this.lblBangTaiKhoan.Size = new System.Drawing.Size(392, 28);
            this.lblBangTaiKhoan.TabIndex = 0;
            this.lblBangTaiKhoan.Text = "Bảng tài khoản";
            this.lblBangTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeight = 34;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountId,
            this.colAccountEmployeeId,
            this.colUsername,
            this.colPasswordHash,
            this.colRoleId,
            this.colAccountIsActive,
            this.colCreatedAt});
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(10, 84);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvTaiKhoan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1185, 160);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // colAccountId
            // 
            this.colAccountId.HeaderText = "Account ID";
            this.colAccountId.MinimumWidth = 8;
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.ReadOnly = true;
            // 
            // colAccountEmployeeId
            // 
            this.colAccountEmployeeId.HeaderText = "Employee ID";
            this.colAccountEmployeeId.MinimumWidth = 8;
            this.colAccountEmployeeId.Name = "colAccountEmployeeId";
            this.colAccountEmployeeId.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.MinimumWidth = 8;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colPasswordHash
            // 
            this.colPasswordHash.HeaderText = "Password Hash";
            this.colPasswordHash.MinimumWidth = 8;
            this.colPasswordHash.Name = "colPasswordHash";
            this.colPasswordHash.ReadOnly = true;
            // 
            // colRoleId
            // 
            this.colRoleId.HeaderText = "RoleId";
            this.colRoleId.MinimumWidth = 8;
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.ReadOnly = true;
            // 
            // colAccountIsActive
            // 
            this.colAccountIsActive.HeaderText = "Is Active";
            this.colAccountIsActive.MinimumWidth = 8;
            this.colAccountIsActive.Name = "colAccountIsActive";
            this.colAccountIsActive.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Created At";
            this.colCreatedAt.MinimumWidth = 8;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // pnlTimKiemTK
            // 
            this.pnlTimKiemTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimKiemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlTimKiemTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiemTK.Controls.Add(this.txtTimKiemTK);
            this.pnlTimKiemTK.Controls.Add(this.btnTimKiemTK);
            this.pnlTimKiemTK.Location = new System.Drawing.Point(10, 10);
            this.pnlTimKiemTK.Name = "pnlTimKiemTK";
            this.pnlTimKiemTK.Size = new System.Drawing.Size(1185, 36);
            this.pnlTimKiemTK.TabIndex = 3;
            // 
            // txtTimKiemTK
            // 
            this.txtTimKiemTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtTimKiemTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemTK.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemTK.Location = new System.Drawing.Point(6, 6);
            this.txtTimKiemTK.Name = "txtTimKiemTK";
            this.txtTimKiemTK.Size = new System.Drawing.Size(1105, 26);
            this.txtTimKiemTK.TabIndex = 0;
            this.txtTimKiemTK.Text = "Tìm kiếm tài khoản...";
            // 
            // btnTimKiemTK
            // 
            this.btnTimKiemTK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimKiemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTimKiemTK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimKiemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTK.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTK.Location = new System.Drawing.Point(1117, 4);
            this.btnTimKiemTK.Name = "btnTimKiemTK";
            this.btnTimKiemTK.Size = new System.Drawing.Size(64, 27);
            this.btnTimKiemTK.TabIndex = 1;
            this.btnTimKiemTK.Text = "Tìm kiếm";
            this.btnTimKiemTK.UseVisualStyleBackColor = false;
            // 
            // pnlBangNhanVien
            // 
            this.pnlBangNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBangNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlBangNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBangNhanVien.Controls.Add(this.lblBangNhanVien);
            this.pnlBangNhanVien.Controls.Add(this.dgvNhanVien);
            this.pnlBangNhanVien.Controls.Add(this.pnlTimKiemNV);
            this.pnlBangNhanVien.Location = new System.Drawing.Point(388, 399);
            this.pnlBangNhanVien.Name = "pnlBangNhanVien";
            this.pnlBangNhanVien.Size = new System.Drawing.Size(1207, 252);
            this.pnlBangNhanVien.TabIndex = 2;
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
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 34;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpId,
            this.colFirstName,
            this.colLastName,
            this.colImageURL,
            this.colPhone,
            this.colEmail,
            this.colEmpIsActive,
            this.colDeletedAt,
            this.colDeletedBy});
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 87);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.Size = new System.Drawing.Size(1185, 153);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // colEmpId
            // 
            this.colEmpId.HeaderText = "Employee ID";
            this.colEmpId.MinimumWidth = 8;
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 8;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 8;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colImageURL
            // 
            this.colImageURL.HeaderText = "Image URL";
            this.colImageURL.MinimumWidth = 8;
            this.colImageURL.Name = "colImageURL";
            this.colImageURL.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colEmpIsActive
            // 
            this.colEmpIsActive.HeaderText = "IsActive";
            this.colEmpIsActive.MinimumWidth = 8;
            this.colEmpIsActive.Name = "colEmpIsActive";
            this.colEmpIsActive.ReadOnly = true;
            // 
            // colDeletedAt
            // 
            this.colDeletedAt.HeaderText = "Deleted At";
            this.colDeletedAt.MinimumWidth = 8;
            this.colDeletedAt.Name = "colDeletedAt";
            this.colDeletedAt.ReadOnly = true;
            // 
            // colDeletedBy
            // 
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
            this.pnlTimKiemNV.Size = new System.Drawing.Size(1185, 36);
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
            this.txtTimKiemNV.Size = new System.Drawing.Size(1105, 26);
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
            this.btnTimKiemNV.Location = new System.Drawing.Point(1117, 4);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(64, 27);
            this.btnTimKiemNV.TabIndex = 1;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = false;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1613, 659);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlBangTaiKhoan);
            this.Controls.Add(this.pnlBangNhanVien);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tài Khoản";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlBangTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.pnlTimKiemTK.ResumeLayout(false);
            this.pnlTimKiemTK.PerformLayout();
            this.pnlBangNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlTimKiemNV.ResumeLayout(false);
            this.pnlTimKiemNV.PerformLayout();
            this.ResumeLayout(false);

        }

        // Declare controls as fields
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private ComboBox cboChucVu;
        private ComboBox cboNhanVien;
        private DataGridView dgvTaiKhoan;
        private DataGridView dgvNhanVien;
        private TextBox txtTimKiemTK;
        private TextBox txtTimKiemNV;
        private Button btnTimKiemTK;
        private Button btnTimKiemNV;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Panel pnlInput;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Label lblChucVu;
        private Label lblNhanVien;
        private Panel pnlBangTaiKhoan;
        private Label lblBangTaiKhoan;
        private DataGridViewTextBoxColumn colAccountId;
        private DataGridViewTextBoxColumn colAccountEmployeeId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPasswordHash;
        private DataGridViewTextBoxColumn colRoleId;
        private DataGridViewTextBoxColumn colAccountIsActive;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Panel pnlBangNhanVien;
        private Label lblBangNhanVien;
        private DataGridViewTextBoxColumn colEmpId;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colImageURL;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colEmpIsActive;
        private DataGridViewTextBoxColumn colDeletedAt;
        private DataGridViewTextBoxColumn colDeletedBy;
        private Panel pnlTimKiemTK;
        private Panel pnlTimKiemNV;

        // Aliases to match existing FormAccount.cs field names 
        private DataGridView dgvAccount;
        private DataGridView dgvEmployee;
        private ComboBox comboBoxRole;
        private TextBox textBoxEmployee;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
    }
}