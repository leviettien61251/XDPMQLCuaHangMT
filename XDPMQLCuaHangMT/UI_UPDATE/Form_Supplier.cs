// SupplierForm.cs
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        public SupplierForm(int employeeId_)
        {
            InitializeComponent();
        }
        Supplier supplier;
        BUS_Supplier busSupplier = new BUS_Supplier();
        protected int supplierId;
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvSupplier.DataSource = busSupplier.GetAllSuppliers();
        }
        private void dgv_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierId = dgvSupplier.CurrentRow.Cells[0].Value != null ? Convert.ToInt32(dgvSupplier.CurrentRow.Cells[0].Value) : 0;
            txtSupplierName.Text = dgvSupplier.CurrentRow.Cells[1].Value != null ? dgvSupplier.CurrentRow.Cells[1].Value.ToString() : "";
            txtContact.Text = dgvSupplier.CurrentRow.Cells[2].Value != null ? dgvSupplier.CurrentRow.Cells[2].Value.ToString() : "";
            txtPhone.Text = dgvSupplier.CurrentRow.Cells[3].Value != null ? dgvSupplier.CurrentRow.Cells[3].Value.ToString() : "";
            txtEmail.Text = dgvSupplier.CurrentRow.Cells[4].Value != null ? dgvSupplier.CurrentRow.Cells[4].Value.ToString() : "";
            txtAddress.Text = dgvSupplier.CurrentRow.Cells[5].Value != null ? dgvSupplier.CurrentRow.Cells[5].Value.ToString() : "";
        }
        private void ClearInputFields()
        {
            txtSupplierName.Clear();
            txtContact.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            string contactName = txtContact.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            supplier = new Supplier(name, contactName, phone, email, address);

            try
            {
                if (busSupplier.InsertSupplier(supplier))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            string contactName = txtContact.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            supplier = new Supplier(supplierId, name, contactName, phone, email, address);

            try
            {
                if (busSupplier.UpdateSupplier(supplier))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
            ClearInputFields();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            string contactName = txtContact.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            supplier = new Supplier(supplierId, name, contactName, phone, email, address);

            try
            {
                if (busSupplier.DeleteSupplier(supplier))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadData();
            ClearInputFields();
        }
        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            string searchKeywords = txtSearchSupplier.Text;
            dgvSupplier.DataSource = busSupplier.SearchSupplierByName(searchKeywords);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}