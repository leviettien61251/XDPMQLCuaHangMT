// EmployeeForm.cs
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(int employeeId_)
        {
            InitializeComponent();
            this.employeeId = employeeId_;
        }
        protected string selectedFile, isActive;
        int employeeId;
        BUS_Employee busEmployee = new BUS_Employee();
        Employee dtoEmployee = new Employee();
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            dgvEmployees.DataSource = busEmployee.GetAllEmployeess();
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Mã nhân viên"].Value);
            txtFirstName.Text = dgvEmployees.CurrentRow.Cells["Tên"].Value != null ? dgvEmployees.CurrentRow.Cells["Tên"].Value.ToString() : "";
            txtLastName.Text = dgvEmployees.CurrentRow.Cells["Họ"].Value != null ? dgvEmployees.CurrentRow.Cells["Họ"].Value.ToString() : "";
            txtPhone.Text = dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value != null ? dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value.ToString() : "";
            txtEmail.Text = dgvEmployees.CurrentRow.Cells["Email"].Value != null ? dgvEmployees.CurrentRow.Cells["Email"].Value.ToString() : "";
            picEmployee.ImageLocation = dgvEmployees.CurrentRow.Cells["Hình ảnh"].Value != null ? dgvEmployees.CurrentRow.Cells["Hình ảnh"].Value.ToString() : "";
            selectedFile = picEmployee.ImageLocation;
            checkBoxIsActive.Checked = dgvEmployees.CurrentRow.Cells["Trạng thái"].Value != null && dgvEmployees.CurrentRow.Cells["Trạng thái"].Value.ToString() == "True" ? true : false;
        }

        private void ClearInputFields()
        {
            employeeId = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            picEmployee.ImageLocation = null;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string imageURL = selectedFile;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            dtoEmployee = new Employee
            {
                firstName = firstName,
                lastName = lastName,
                phone = phone,
                email = email,
                imageURL = imageURL
            };

            try
            {
                if (busEmployee.InsertEmployee(dtoEmployee))
                {
                    MessageBox.Show("Thêm mới nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm mới nhân viên không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadEmployeeData();
            ClearInputFields();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string imageURL = selectedFile;
            string IsActive = isActive;

            dtoEmployee = new Employee
            {
                employeeId = employeeId,
                firstName = firstName,
                lastName = lastName,
                phone = phone,
                email = email,
                imageURL = imageURL,
                isActive = IsActive
            };

            try
            {
                if (busEmployee.UpdateEmployee(dtoEmployee))
                {
                    MessageBox.Show("Sửa nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadEmployeeData();
            ClearInputFields();
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (busEmployee.SoftDeleteEmployee(employeeId))
                {
                    MessageBox.Show("Xóa nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadEmployeeData();
            ClearInputFields();
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
            }
            picEmployee.ImageLocation = selectedFile;
        }
        private void txtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchEmp.Text.Trim();
            dgvEmployees.DataSource = busEmployee.SearchEmployees(searchKeyword);
        }
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["Mã nhân viên"].Value);
            bool currentStatus = Convert.ToBoolean(dgvEmployees.CurrentRow.Cells["Trạng thái"].Value);
            dgvEmployees.CurrentRow.Cells["Trạng thái"].Value = !currentStatus;
            busEmployee.SoftDeleteEmployee(employeeId);
            LoadEmployeeData();
            ClearInputFields();
        }
        private void dgvEmployees_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //e.Cell.Selected = false;

            //lblPhone.Text = e.StateChanged.ToString() ;
            //LoadEmployeeData();
        }
        private void checkBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            isActive = checkBoxIsActive.Checked ? "1" : "0";
        }
    }
}