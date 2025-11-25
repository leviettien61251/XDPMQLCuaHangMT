using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }
        Supplier supplier;
        BUS_Supplier BUS_Supplier = new BUS_Supplier();
        private int supplierId;

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv_Supplier.DataSource = new BUS.BUS_Supplier().GetAllSuppliers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contactName = textBoxContact.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            Supplier supplier = new Supplier(name, contactName, phone, email, address);

            try
            {
                if (BUS_Supplier.InsertSupplier(supplier))
                {
                    MessageBox.Show("Supplier added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contactName = textBoxContact.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;

            try
            {
                if (BUS_Supplier.UpdateSupplier(supplierId, name, contactName, phone, email, address))
                {
                    MessageBox.Show("Supplier updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update supplier.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadData();
        }

        private void dgv_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierId = dgv_Supplier.CurrentRow.Cells[0].Value != null ? Convert.ToInt32(dgv_Supplier.CurrentRow.Cells[0].Value) : 0;
            textBoxName.Text = dgv_Supplier.CurrentRow.Cells[1].Value.ToString();
            textBoxContact.Text = dgv_Supplier.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dgv_Supplier.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dgv_Supplier.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dgv_Supplier.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
