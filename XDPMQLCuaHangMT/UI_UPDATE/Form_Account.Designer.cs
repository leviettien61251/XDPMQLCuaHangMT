// FormAccount.Designer.cs
// UI-only: thiết kế lại theo mẫu, nền trắng, Designer-friendly (không có mã động trong InitializeComponent).
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class AccountForm
    {
        private IContainer components = null;

        private TableLayoutPanel mainLayout;

        private Panel pnlInput;
        private Label lblTenDangNhap;
        internal TextBox txtTenDangNhap;
        private Label lblMatKhau;
        internal TextBox txtMatKhau;
        private Label lblChucVu;
        internal ComboBox cboChucVu;
        private Label lblNhanVien;
        internal TextBox textBoxEmployee;
        private FlowLayoutPanel inputActionPanel;
        internal Button btnThem;
        internal Button btnSua;
        internal Button btnXoa;

        private Panel pnlBangTaiKhoan;
        private Label lblBangTaiKhoan;
        private Panel pnlTimKiemTK;
        internal TextBox txtTimKiemTK;
        internal Button btnTimKiemTK;

        private Panel pnlBangNhanVien;
        private Label lblBangNhanVien;
        private Panel pnlTimKiemNV;
        internal TextBox txtTimKiemNV;
        internal Button btnTimKiemNV;

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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.inputActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.rightStack = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBangTaiKhoan = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.accountSearchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiemTK = new System.Windows.Forms.TextBox();
            this.btnTimKiemTK = new System.Windows.Forms.Button();
            this.lblBangTaiKhoan = new System.Windows.Forms.Label();
            this.pnlBangNhanVien = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.empSearchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.lblBangNhanVien = new System.Windows.Forms.Label();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.pnlTimKiemTK = new System.Windows.Forms.Panel();
            this.pnlTimKiemNV = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.inputLayout.SuspendLayout();
            this.inputActionPanel.SuspendLayout();
            this.rightStack.SuspendLayout();
            this.pnlBangTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.accountSearchLayout.SuspendLayout();
            this.pnlBangNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.empSearchLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.White;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.pnlInput, 0, 0);
            this.mainLayout.Controls.Add(this.rightStack, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(1503, 641);
            this.mainLayout.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.inputLayout);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInput.Location = new System.Drawing.Point(3, 3);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(12);
            this.pnlInput.Size = new System.Drawing.Size(374, 635);
            this.pnlInput.TabIndex = 0;
            // 
            // inputLayout
            // 
            this.inputLayout.AutoSize = true;
            this.inputLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputLayout.ColumnCount = 1;
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputLayout.Controls.Add(this.lblTenDangNhap, 0, 0);
            this.inputLayout.Controls.Add(this.txtTenDangNhap, 0, 1);
            this.inputLayout.Controls.Add(this.lblMatKhau, 0, 2);
            this.inputLayout.Controls.Add(this.txtMatKhau, 0, 3);
            this.inputLayout.Controls.Add(this.lblChucVu, 0, 4);
            this.inputLayout.Controls.Add(this.cboChucVu, 0, 5);
            this.inputLayout.Controls.Add(this.lblNhanVien, 0, 6);
            this.inputLayout.Controls.Add(this.inputActionPanel, 0, 8);
            this.inputLayout.Controls.Add(this.txtNhanVien, 0, 7);
            this.inputLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputLayout.Location = new System.Drawing.Point(12, 12);
            this.inputLayout.Name = "inputLayout";
            this.inputLayout.RowCount = 9;
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.inputLayout.Size = new System.Drawing.Size(350, 308);
            this.inputLayout.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lblTenDangNhap.Location = new System.Drawing.Point(3, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(344, 28);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            this.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.White;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Location = new System.Drawing.Point(3, 31);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(344, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lblMatKhau.Location = new System.Drawing.Point(3, 62);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(344, 28);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(3, 93);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(344, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucVu.Location = new System.Drawing.Point(3, 124);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(344, 28);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ:";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboChucVu
            // 
            this.cboChucVu.BackColor = System.Drawing.Color.White;
            this.cboChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.ForeColor = System.Drawing.Color.Black;
            this.cboChucVu.Location = new System.Drawing.Point(3, 155);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(344, 21);
            this.cboChucVu.TabIndex = 5;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblNhanVien.Location = new System.Drawing.Point(3, 186);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(344, 28);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "Nhân viên:";
            this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputActionPanel
            // 
            this.inputActionPanel.AutoSize = true;
            this.inputActionPanel.Controls.Add(this.btnThem);
            this.inputActionPanel.Controls.Add(this.btnSua);
            this.inputActionPanel.Controls.Add(this.btnXoa);
            this.inputActionPanel.Controls.Add(this.buttonClear);
            this.inputActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputActionPanel.Location = new System.Drawing.Point(3, 251);
            this.inputActionPanel.Name = "inputActionPanel";
            this.inputActionPanel.Size = new System.Drawing.Size(344, 54);
            this.inputActionPanel.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSua.Location = new System.Drawing.Point(84, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXoa.Location = new System.Drawing.Point(165, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhanVien.Location = new System.Drawing.Point(3, 217);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(344, 20);
            this.txtNhanVien.TabIndex = 9;
            // 
            // rightStack
            // 
            this.rightStack.BackColor = System.Drawing.Color.White;
            this.rightStack.ColumnCount = 1;
            this.rightStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightStack.Controls.Add(this.pnlBangTaiKhoan, 0, 0);
            this.rightStack.Controls.Add(this.pnlBangNhanVien, 0, 1);
            this.rightStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightStack.Location = new System.Drawing.Point(383, 3);
            this.rightStack.Name = "rightStack";
            this.rightStack.RowCount = 2;
            this.rightStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightStack.Size = new System.Drawing.Size(1117, 635);
            this.rightStack.TabIndex = 1;
            // 
            // pnlBangTaiKhoan
            // 
            this.pnlBangTaiKhoan.BackColor = System.Drawing.Color.White;
            this.pnlBangTaiKhoan.Controls.Add(this.dgvAccount);
            this.pnlBangTaiKhoan.Controls.Add(this.accountSearchLayout);
            this.pnlBangTaiKhoan.Controls.Add(this.lblBangTaiKhoan);
            this.pnlBangTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.pnlBangTaiKhoan.Name = "pnlBangTaiKhoan";
            this.pnlBangTaiKhoan.Padding = new System.Windows.Forms.Padding(12);
            this.pnlBangTaiKhoan.Size = new System.Drawing.Size(1111, 311);
            this.pnlBangTaiKhoan.TabIndex = 0;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(12, 80);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(1087, 219);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // accountSearchLayout
            // 
            this.accountSearchLayout.ColumnCount = 2;
            this.accountSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.accountSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.accountSearchLayout.Controls.Add(this.txtTimKiemTK, 0, 0);
            this.accountSearchLayout.Controls.Add(this.btnTimKiemTK, 1, 0);
            this.accountSearchLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountSearchLayout.Location = new System.Drawing.Point(12, 40);
            this.accountSearchLayout.Name = "accountSearchLayout";
            this.accountSearchLayout.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.accountSearchLayout.RowCount = 1;
            this.accountSearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.accountSearchLayout.Size = new System.Drawing.Size(1087, 40);
            this.accountSearchLayout.TabIndex = 1;
            // 
            // txtTimKiemTK
            // 
            this.txtTimKiemTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemTK.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemTK.Location = new System.Drawing.Point(6, 12);
            this.txtTimKiemTK.Margin = new System.Windows.Forms.Padding(6, 6, 80, 6);
            this.txtTimKiemTK.Name = "txtTimKiemTK";
            this.txtTimKiemTK.Size = new System.Drawing.Size(914, 20);
            this.txtTimKiemTK.TabIndex = 0;
            this.txtTimKiemTK.TextChanged += new System.EventHandler(this.txtTimKiemTK_TextChanged);
            // 
            // btnTimKiemTK
            // 
            this.btnTimKiemTK.AutoSize = true;
            this.btnTimKiemTK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTimKiemTK.Location = new System.Drawing.Point(1003, 9);
            this.btnTimKiemTK.Name = "btnTimKiemTK";
            this.btnTimKiemTK.Size = new System.Drawing.Size(81, 22);
            this.btnTimKiemTK.TabIndex = 1;
            this.btnTimKiemTK.Text = "Tìm kiếm";
            // 
            // lblBangTaiKhoan
            // 
            this.lblBangTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBangTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBangTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lblBangTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.lblBangTaiKhoan.Name = "lblBangTaiKhoan";
            this.lblBangTaiKhoan.Size = new System.Drawing.Size(1087, 28);
            this.lblBangTaiKhoan.TabIndex = 2;
            this.lblBangTaiKhoan.Text = "Bảng tài khoản";
            this.lblBangTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBangNhanVien
            // 
            this.pnlBangNhanVien.BackColor = System.Drawing.Color.White;
            this.pnlBangNhanVien.Controls.Add(this.dgvEmployees);
            this.pnlBangNhanVien.Controls.Add(this.empSearchLayout);
            this.pnlBangNhanVien.Controls.Add(this.lblBangNhanVien);
            this.pnlBangNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangNhanVien.Location = new System.Drawing.Point(3, 320);
            this.pnlBangNhanVien.Name = "pnlBangNhanVien";
            this.pnlBangNhanVien.Padding = new System.Windows.Forms.Padding(12);
            this.pnlBangNhanVien.Size = new System.Drawing.Size(1111, 312);
            this.pnlBangNhanVien.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 79);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(1087, 221);
            this.dgvEmployees.TabIndex = 3;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // empSearchLayout
            // 
            this.empSearchLayout.ColumnCount = 2;
            this.empSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.empSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.empSearchLayout.Controls.Add(this.txtTimKiemNV, 0, 0);
            this.empSearchLayout.Controls.Add(this.btnTimKiemNV, 1, 0);
            this.empSearchLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.empSearchLayout.Location = new System.Drawing.Point(12, 40);
            this.empSearchLayout.Name = "empSearchLayout";
            this.empSearchLayout.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.empSearchLayout.RowCount = 1;
            this.empSearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.empSearchLayout.Size = new System.Drawing.Size(1087, 39);
            this.empSearchLayout.TabIndex = 1;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemNV.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemNV.Location = new System.Drawing.Point(3, 9);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(994, 20);
            this.txtTimKiemNV.TabIndex = 0;
            this.txtTimKiemNV.TextChanged += new System.EventHandler(this.txtTimKiemNV_TextChanged);
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.AutoSize = true;
            this.btnTimKiemNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTimKiemNV.Location = new System.Drawing.Point(1003, 9);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(81, 21);
            this.btnTimKiemNV.TabIndex = 1;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            // 
            // lblBangNhanVien
            // 
            this.lblBangNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBangNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBangNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblBangNhanVien.Location = new System.Drawing.Point(12, 12);
            this.lblBangNhanVien.Name = "lblBangNhanVien";
            this.lblBangNhanVien.Size = new System.Drawing.Size(1087, 28);
            this.lblBangNhanVien.TabIndex = 2;
            this.lblBangNhanVien.Text = "Bảng nhân viên";
            this.lblBangNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.BackColor = System.Drawing.Color.White;
            this.textBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmployee.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmployee.Location = new System.Drawing.Point(0, 0);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployee.TabIndex = 0;
            this.textBoxEmployee.Visible = false;
            // 
            // pnlTimKiemTK
            // 
            this.pnlTimKiemTK.BackColor = System.Drawing.Color.White;
            this.pnlTimKiemTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiemTK.Location = new System.Drawing.Point(0, 0);
            this.pnlTimKiemTK.Name = "pnlTimKiemTK";
            this.pnlTimKiemTK.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTimKiemTK.Size = new System.Drawing.Size(200, 40);
            this.pnlTimKiemTK.TabIndex = 0;
            // 
            // pnlTimKiemNV
            // 
            this.pnlTimKiemNV.BackColor = System.Drawing.Color.White;
            this.pnlTimKiemNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiemNV.Location = new System.Drawing.Point(0, 0);
            this.pnlTimKiemNV.Name = "pnlTimKiemNV";
            this.pnlTimKiemNV.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTimKiemNV.Size = new System.Drawing.Size(200, 40);
            this.pnlTimKiemNV.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(246, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(71, 29);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Làm mới";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // AccountForm
            // 
            this.ClientSize = new System.Drawing.Size(1503, 641);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tài Khoản";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.mainLayout.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.inputLayout.ResumeLayout(false);
            this.inputLayout.PerformLayout();
            this.inputActionPanel.ResumeLayout(false);
            this.inputActionPanel.PerformLayout();
            this.rightStack.ResumeLayout(false);
            this.pnlBangTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.accountSearchLayout.ResumeLayout(false);
            this.accountSearchLayout.PerformLayout();
            this.pnlBangNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.empSearchLayout.ResumeLayout(false);
            this.empSearchLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel inputLayout;
        private TableLayoutPanel rightStack;
        private TableLayoutPanel accountSearchLayout;
        private TableLayoutPanel empSearchLayout;
        private DataGridView dgvAccount;
        private DataGridView dgvEmployees;
        private TextBox txtNhanVien;
        private Button buttonClear;
    }
}