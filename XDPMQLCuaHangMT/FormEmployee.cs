using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
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
        BUS_Account busAccount = new BUS_Account();
        Employee dtoEmployee = new Employee();
        private string selectedImagePath = string.Empty;
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            LoadAccountData();
            // wire search buttons
            this.btnSearchAccount.Click += BtnSearchAccount_Click;
            this.btnSearch.Click += BtnSearch_Click;
        }
        private void LoadEmployeeData()
        {
            dgvEmployees.DataSource = busEmployee.GetAllEmployeess();
        }
        private void LoadAccountData()
        {
            try
            {
                var dt = busAccount.GetAllAccounts();
                dgvAccounts.DataSource = dt;
            }
            catch { dgvAccounts.DataSource = null; }
        }
        private void BtnSearchAccount_Click(object sender, EventArgs e)
        {
            var q = txtSearchAccount.Text?.Trim();
            try
            {
                var dt = busAccount.GetAllAccounts();
                if (dt != null && !string.IsNullOrEmpty(q))
                {
                    q = q.Replace("'", "''");
                    var dv = dt.DefaultView;
                    dv.RowFilter = $"Convert(AccountId, 'System.String') LIKE '%{q}%' OR Username LIKE '%{q}%' OR Convert(EmployeeId,'System.String') LIKE '%{q}%';";
                    dgvAccounts.DataSource = dv;
                }
                else
                {
                    dgvAccounts.DataSource = dt;
                }
            }
            catch { }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text?.Trim();
            try
            {
                var dt = busEmployee.GetAllEmployeess();
                if (dt != null && !string.IsNullOrEmpty(q))
                {
                    q = q.Replace("'", "''");
                    var dv = dt.DefaultView;
                    dv.RowFilter = $"FirstName LIKE '%{q}%' OR LastName LIKE '%{q}%' OR Phone LIKE '%{q}%' OR Email LIKE '%{q}%';";
                    dgvEmployees.DataSource = dv;
                }
                else
                {
                    dgvEmployees.DataSource = dt;
                }
            }
            catch { }
        }
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeId_ = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeId"].Value);
            textBoxFirstName.Text = dgvEmployees.CurrentRow.Cells["Tên"].Value != null ? dgvEmployees.CurrentRow.Cells["Tên"].Value.ToString() : "";
            textBoxLastName.Text = dgvEmployees.CurrentRow.Cells["Họ"].Value != null ? dgvEmployees.CurrentRow.Cells["Họ"].Value.ToString() : "";
            textBoxPhone.Text = dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value != null ? dgvEmployees.CurrentRow.Cells["Số điện thoại"].Value.ToString() : "";
            textBoxEmail.Text = dgvEmployees.CurrentRow.Cells["Email"].Value != null ? dgvEmployees.CurrentRow.Cells["Email"].Value.ToString() : "";
            // try to load image if column exists
            try
            {
                if (dgvEmployees.Columns.Contains("ImageURL") && dgvEmployees.CurrentRow.Cells["ImageURL"].Value != null)
                {
                    var url = dgvEmployees.CurrentRow.Cells["ImageURL"].Value.ToString();
                    if (!string.IsNullOrEmpty(url) && System.IO.File.Exists(url))
                    {
                        selectedImagePath = url;
                        pictureBox1.Image = Image.FromFile(url);
                    }
                }
            }
            catch { /* ignore image load errors */ }
        }

        private void ClearInputFields()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            selectedImagePath = string.Empty;
            pictureBox1.Image = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string imageURL = selectedImagePath ?? string.Empty;

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
            string imageURL = selectedImagePath ?? string.Empty;

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

        // Handler for image button in designer
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePath = dlg.FileName;
                        pictureBox1.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }

    }
}
