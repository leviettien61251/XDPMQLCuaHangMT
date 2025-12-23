using BUS;
using DTO;
using System;
using System.Windows.Forms;
namespace XDPMQLCuaHangMT
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        int employeeId_;
        BUS_Employee busEmployee = new BUS_Employee();
        Employee dtoEmployee = new Employee();
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            dgvEmployees.DataSource = busEmployee.GetAllEmployeess();
        }
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeId_ = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeId"].Value);
            textBoxFirstName.Text = dgvEmployees.CurrentRow.Cells["Tên"].Value != null ? dgvEmployees.CurrentRow.Cells["Tên"].Value.ToString() : "";
            textBoxLastName.Text = dgvEmployees.CurrentRow.Cells["Họ"].Value != null ? dgvEmployees.CurrentRow.Cells["Họ"].Value.ToString() : "";
            textBoxPhone.Text = dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value != null ? dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value.ToString() : "";
            textBoxEmail.Text = dgvEmployees.CurrentRow.Cells["Email"].Value != null ? dgvEmployees.CurrentRow.Cells["Email"].Value.ToString() : "";
        }

        private void ClearInputFields()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string imageURL = " ";

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
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string imageURL = " ";

            dtoEmployee = new Employee
            {
                employeeId = employeeId_,
                firstName = firstName,
                lastName = lastName,
                phone = phone,
                email = email,
                imageURL = imageURL
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
                if (busEmployee.SoftDeleteEmployee(employeeId_))
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
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadEmployeeData();
            ClearInputFields();
        }

    }
}
