using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace XDPMQLCuaHangMT
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        protected int employeeId, voucherId;
        public FormStock(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }
        StockVoucher dtoStockVoucher;
        DataTable dtEmployee;
        BUS_StockVoucher busStockVoucher = new BUS_StockVoucher();
        BUS_Employee busEmployee = new BUS_Employee();
        private void buttonStockDetial_Click(object sender, EventArgs e)
        {
            FormStockDetail formStockDetail = new FormStockDetail();
            formStockDetail.ShowDialog();
            formStockDetail.WindowState = FormWindowState.Maximized;
            formStockDetail.BringToFront();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            dtEmployee = busEmployee.GetEmployeeById(employeeId);
            dgvStock.DataSource = busStockVoucher.GetAllStockVouchers();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxStockType.Text = dgvStock.CurrentRow.Cells["Loại"].Value.ToString();
            textBoxDate.Text = dgvStock.CurrentRow.Cells["Ngày nhập/xuất"].Value.ToString();
            textBoxNote.Text = dgvStock.CurrentRow.Cells["Ghi chú"].Value.ToString();
            labelStockId.Text = "Mã phiếu: " + dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString();
            voucherId = Int32.Parse(dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString());
        }

        private void comboBoxStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelType.Text = comboBoxStockType.Text.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string voucherType = comboBoxStockType.Text.ToString();
            int createdBy = employeeId;
            string notes = textBoxNote.Text.ToString();

            dtoStockVoucher = new StockVoucher(voucherType, createdBy, notes);
            if (!busStockVoucher.InsertStockVoucher(dtoStockVoucher))
            {
                MessageBox.Show("Thêm phiếu không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm phiếu thành công");
                Load_Data();
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string voucherType = comboBoxStockType.Text.ToString();
            string notes = textBoxNote.Text.ToString();

            dtoStockVoucher = new StockVoucher();
            dtoStockVoucher.voucherId = voucherId;
            dtoStockVoucher.voucherType = voucherType;
            dtoStockVoucher.note = notes;
            if (!busStockVoucher.UpdateStockVoucher(dtoStockVoucher))
            {
                MessageBox.Show("Sửa phiếu không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Sửa phiếu thành công");
                Load_Data();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            dtoStockVoucher = new StockVoucher();
            dtoStockVoucher.voucherId = voucherId;
            if (!busStockVoucher.DeleteStockVoucher(dtoStockVoucher))
            {
                MessageBox.Show("Xóa phiếu không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Xóa phiếu thành công");
                Load_Data();
            }
        }
    }
}
