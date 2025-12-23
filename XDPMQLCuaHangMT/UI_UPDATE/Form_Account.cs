// AccountForm.cs
using BUS;
using DTO;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        public AccountForm(int employeeId_)
        {
            InitializeComponent();
            this.employeeId = employeeId_;
        }
        protected int employeeId;
        Regex regexUsername = new Regex(@"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$");
        Role dtoRole = new Role();
        Employee dtoEmployee = new Employee();
        BUS_Account busAccount = new BUS_Account();
        BUS_Employee busEmployee = new BUS_Employee();
        Account account;
        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboboxRoles();
        }
        public void LoadData()
        {
            dgvAccount.DataSource = LoadAccounts();
            dgvEmployees.DataSource = LoadEmployees();
        }
        private DataTable LoadAccounts()
        {
            return busAccount.GetAllAccounts();
        }
        private DataTable LoadEmployees()
        {
            return busAccount.GetAllEmployees();
        }
        private void LoadComboboxRoles()
        {
            cboChucVu.DataSource = busAccount.GetAllRoles();
            cboChucVu.DisplayMember = "RoleName";
            cboChucVu.ValueMember = "RoleId";
            lblChucVu.Text = cboChucVu.SelectedValue.ToString();
        }
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtoEmployee.employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            int employeeId_ = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            dtoEmployee.employeeId = employeeId_;
            txtNhanVien.Text = dgvEmployees.CurrentRow.Cells["Họ"].Value.ToString() + " " + dgvEmployees.CurrentRow.Cells["Tên"].Value.ToString();
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDangNhap.Text = dgvAccount.CurrentRow.Cells["Tên đăng nhập"].Value.ToString();
            cboChucVu.DisplayMember = "Chức vụ";
            int employeeId__ = Convert.ToInt32(dgvAccount.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            object employeeName = busEmployee.GetEmployeeNameById(employeeId__);
            txtNhanVien.Text = employeeName.ToString();
        }
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roleId_;
            string role__ = cboChucVu.SelectedValue.ToString();
            dtoRole.roleId = int.TryParse(role__, out roleId_) ? roleId_ : 0;
            dtoRole.roleId = roleId_;
        }
        private void ClearInputFields()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhanVien.Clear();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            int roleId = dtoRole.roleId;
            int employeeId = dtoEmployee.employeeId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (!regexUsername.IsMatch(username))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PasswordHash hash = new PasswordHash(password);
            password = hash.Hash();
            account = new Account
            {
                username = username,
                password = password,
                roleId = roleId,
                employeeId = employeeId
            };
            if (busAccount.InsertAccount(account))
            {
                MessageBox.Show("Thêm mới tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm mới tài khoản không thành công");
            }
            LoadData();
            ClearInputFields();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            int roleId = dtoRole.roleId;
            int employeeId = dtoEmployee.employeeId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (!regexUsername.IsMatch(username))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PasswordHash hash = new PasswordHash(password);
            password = hash.Hash();
            account = new Account
            {
                username = username,
                password = password,
                roleId = roleId,
                employeeId = employeeId
            };
            if (busAccount.UpdateAccount(account))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản không thành công");
            }
            LoadData();
            ClearInputFields();
        }

        private void txtTimKiemTK_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtTimKiemTK.Text.Trim();
            dgvAccount.DataSource = busAccount.SearchingAccounts(searchKeyword);
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtTimKiemNV.Text.Trim();
            busEmployee.SearchEmployees(searchKeyword);
            dgvEmployees.DataSource = busEmployee.SearchEmployees(searchKeyword); ;
        }
    }
}