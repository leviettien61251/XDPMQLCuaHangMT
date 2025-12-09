using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace XDPMQLCuaHangMT
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }
        Regex regexUsername = new Regex(@"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$");
        Role dtoRole = new Role();
        Employee dtoEmployee = new Employee();
        BUS_Account busAccount = new BUS_Account();
        Account account;

        private void FormAccount_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboboxRoles();
        }
        public void LoadData()
        {
            dgvAccount.DataSource = LoadAccounts();
            dgvEmployee.DataSource = LoadEmployees();
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
            comboBoxRole.DataSource = busAccount.GetAllRoles();
            comboBoxRole.DisplayMember = "RoleName";
            comboBoxRole.ValueMember = "RoleId";
        }
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtoEmployee.employeeId = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["EmployeeId"].Value.ToString());
            int employeeId_;
            dtoEmployee.employeeId = int.TryParse(dgvEmployee.CurrentRow.Cells["EmployeeId"].Value.ToString(), out employeeId_) ? employeeId_ : 0;
            textBoxEmployee.Text = dgvEmployee.CurrentRow.Cells["Họ"].Value.ToString() + " " + dgvEmployee.CurrentRow.Cells["Tên"].Value.ToString();
        }
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roleId_;
            string role__ = comboBoxRole.SelectedValue.ToString();
            dtoRole.roleId = int.TryParse(role__, out roleId_) ? roleId_ : 0;
            dtoRole.roleId = roleId_;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            int roleId = dtoRole.roleId;
            int employeeId = dtoEmployee.employeeId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (regexUsername.IsMatch(username))
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
        }


    }
}
