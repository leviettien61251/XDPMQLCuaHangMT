// AccountForm.Designer.cs
// Tạo UI cho Form Tài Khoản (chỉ UI, không có logic).
// Lưu ý: đổi namespace/class name nếu cần để phù hợp project của bạn.

using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    partial class AccountForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls chính
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox grpForm;         // chứa các ô nhập
        private System.Windows.Forms.GroupBox grpTable;        // chứa DataGridView
        private System.Windows.Forms.TableLayoutPanel formLayout;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;

        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.FlowLayoutPanel actionPanel; // chứa nút Thêm/Sửa/Xóa
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvAccounts;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();

            // Main layout: 2 cột (form bên trái, bảng bên phải), responsive
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.RowCount = 2;
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F)); // form
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F)); // bảng
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F)); // search
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F)); // content

            // GroupBox chứa form nhập
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.grpForm.Text = "Form Tài Khoản";
            this.grpForm.Dock = System.Windows.Forms.DockStyle.Fill;

            // GroupBox chứa bảng
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.grpTable.Text = "Bảng tài khoản";
            this.grpTable.Dock = System.Windows.Forms.DockStyle.Fill;

            // Form layout bên trong groupbox: 2 cột (label + control)
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.formLayout.ColumnCount = 2;
            this.formLayout.RowCount = 6;
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F)); // label
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F)); // control

            this.formLayout.RowStyles.Clear();
            this.formLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // phần còn lại cho Data/controls

            // Controls: Username
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            // Ghi chú: txtUsername dùng để nhập Username; bind với Accounts.Username khi gắn logic.

            // Controls: Password
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true; // ẩn ký tự
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            // Ghi chú: txtPassword chỉ UI; bạn có thể hash trước khi lưu vào PasswordHash.

            // Controls: Role (ComboBox)
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRole.Text = "Chức vụ:";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;

            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboRole.Name = "cboRole";
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Dock = System.Windows.Forms.DockStyle.Fill;
            // Ghi chú: cboRole sẽ được bind với Roles.RoleId/RoleName.

            // Controls: Employee (ComboBox)
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblEmployee.Text = "Nhân viên:";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Fill;

            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            // Ghi chú: cboEmployee bind với Employees.EmployeeId/FullName.

            // Controls: IsActive (checkbox)
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.chkIsActive.Text = "Kích hoạt";
            this.chkIsActive.Checked = true;
            this.chkIsActive.Dock = System.Windows.Forms.DockStyle.Left;
            // Ghi chú: chkIsActive tương ứng với Accounts.IsActive.

            // Action buttons (FlowLayoutPanel để tự co dãn)
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.actionPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.AutoSize = true;

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Text = "Thêm";
            this.btnAdd.AutoSize = true;
            // Ghi chú: gắn event handler btnAdd.Click trong code logic của bạn.

            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEdit.Text = "Sửa";
            this.btnEdit.AutoSize = true;

            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete.Text = "Xóa";
            this.btnDelete.AutoSize = true;

            // Thêm nút vào panel
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Controls.Add(this.btnEdit);
            this.actionPanel.Controls.Add(this.btnDelete);

            // Search box (đặt ở hàng trên cùng của mainLayout)
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            // Gán placeholder an toàn bằng reflection (không gây lỗi compile nếu thuộc tính không tồn tại)
            var prop = this.txtSearch.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearch, "Tìm kiếm theo tên hoặc username");
            }

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.AutoSize = true;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;

            // DataGridView cho bảng tài khoản
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // Ghi chú: cột sẽ map tới Accounts: AccountId, Username, RoleName, EmployeeName, IsActive, CreatedAt

            // Tạo layout form: thêm controls vào formLayout theo thứ tự
            // Hàng 0: Username
            this.formLayout.Controls.Add(this.lblUsername, 0, 0);
            this.formLayout.Controls.Add(this.txtUsername, 1, 0);

            // Hàng 1: Password
            this.formLayout.Controls.Add(this.lblPassword, 0, 1);
            this.formLayout.Controls.Add(this.txtPassword, 1, 1);

            // Hàng 2: Role
            this.formLayout.Controls.Add(this.lblRole, 0, 2);
            this.formLayout.Controls.Add(this.cboRole, 1, 2);

            // Hàng 3: Employee
            this.formLayout.Controls.Add(this.lblEmployee, 0, 3);
            this.formLayout.Controls.Add(this.cboEmployee, 1, 3);

            // Hàng 4: IsActive checkbox (span 2 cột)
            this.formLayout.Controls.Add(this.chkIsActive, 1, 4);

            // Hàng 5: Action buttons (span 2 cột)
            this.formLayout.Controls.Add(this.actionPanel, 1, 5);

            // Đặt formLayout vào grpForm
            this.grpForm.Controls.Add(this.formLayout);

            // Bên phải: grpTable chứa DataGridView và search button (search đã ở hàng trên mainLayout)
            // Tạo panel nhỏ để chứa dgv và có padding
            var tableInnerPanel = new System.Windows.Forms.Panel();
            tableInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableInnerPanel.Padding = new System.Windows.Forms.Padding(6);
            tableInnerPanel.Controls.Add(this.dgvAccounts);
            this.grpTable.Controls.Add(tableInnerPanel);

            // Thêm search controls vào một panel để đặt ở hàng 0, cột 0..1
            var searchPanel = new System.Windows.Forms.Panel();
            searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            searchPanel.Padding = new System.Windows.Forms.Padding(6);
            // đặt txtSearch và btnSearch bên trong searchPanel, txtSearch chiếm phần lớn
            this.txtSearch.Width = 300;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            searchPanel.Controls.Add(this.txtSearch);
            searchPanel.Controls.Add(this.btnSearch);
            // sắp xếp vị trí đơn giản
            this.txtSearch.Location = new System.Drawing.Point(6, 6);
            this.btnSearch.Location = new System.Drawing.Point(320, 4);

            // Thêm các phần vào mainLayout
            // Hàng 0 (search) span cả 2 cột: đặt searchPanel ở cột 0, colSpan=2
            this.mainLayout.Controls.Add(searchPanel, 0, 0);
            this.mainLayout.SetColumnSpan(searchPanel, 2);

            // Hàng 1: cột 0 = grpForm, cột 1 = grpTable
            this.mainLayout.Controls.Add(this.grpForm, 0, 1);
            this.mainLayout.Controls.Add(this.grpTable, 1, 1);

            // Thiết lập Form
            this.Controls.Add(this.mainLayout);
            this.Text = "Quản lý Tài Khoản";
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        #endregion
    }
}