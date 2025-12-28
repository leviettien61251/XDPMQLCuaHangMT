using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.UI_UPDATE
{
    public partial class Form_Stock : Form
    {
        public Form_Stock()
        {
            InitializeComponent();
        }
        public Form_Stock(int employeeId_)
        {
            InitializeComponent();
            this.employeeId = employeeId_;
        }
        private void Form_Stock_Load(object sender, System.EventArgs e)
        {
            Load_Data();
        }
        protected int employeeId, voucherId;
        protected string voucherType__;
        StockVoucher dtoStockVoucher;
        DataTable dtEmployee;
        BUS_StockVoucher busStockVoucher = new BUS_StockVoucher();
        BUS_Employee busEmployee = new BUS_Employee();
        private void buttonStockDetial_Click(object sender, EventArgs e)
        {
            if (voucherType__ != "IN")
            {
                FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, voucherId, "", voucherType__);
                formVoucherIN.ShowDialog();
                formVoucherIN.WindowState = FormWindowState.Maximized;
                formVoucherIN.BringToFront();
            }
            else
            {
                FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, voucherId, "", voucherType__);
                formVoucherIN.ShowDialog();
                formVoucherIN.WindowState = FormWindowState.Maximized;
                formVoucherIN.BringToFront();
            }
        }



        private void Load_Data()
        {
            dtEmployee = busEmployee.GetEmployeeById(employeeId);
            dgvStock.DataSource = busStockVoucher.GetAllStockVouchers();
        }
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            voucherType__ = dgvStock.CurrentRow.Cells["Loại"].Value.ToString().Trim();
            cboType.Text = dgvStock.CurrentRow.Cells["Loại"].Value.ToString().Trim();
            dtpDate.Text = dgvStock.CurrentRow.Cells["Ngày nhập/xuất"].Value.ToString();
            txtNote.Text = dgvStock.CurrentRow.Cells["Ghi chú"].Value.ToString();
            txtVoucherId.Text = "Mã phiếu: " + dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString();
            voucherId = Int32.Parse(dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString());
        }

        private void comboBoxStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            voucherType__ = cboType.Text.ToString();
        }
        private void Clear_Fields()
        {
            cboType.Text = "";
            dtpDate.ResetText();
            txtNote.Text = "";
            txtVoucherId.Text = "";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int createdBy = employeeId;
            string notes = txtNote.Text.ToString();

            if (string.IsNullOrEmpty(voucherType__))
            {
                MessageBox.Show("Vui lòng chọn loại phiếu");
                return;
            }
            dtoStockVoucher = new StockVoucher(voucherType__, createdBy, notes);
            if (voucherType__ != "IN")
            {
                FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, dtoStockVoucher.note, voucherType__);
                formVoucherIN.ShowDialog();
                formVoucherIN.WindowState = FormWindowState.Maximized;
                formVoucherIN.BringToFront();
            }
            else
            {
                FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, dtoStockVoucher.note, voucherType__);
                formVoucherIN.ShowDialog();
                formVoucherIN.WindowState = FormWindowState.Maximized;
                formVoucherIN.BringToFront();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string notes = txtNote.Text.ToString();

            dtoStockVoucher = new StockVoucher();
            dtoStockVoucher.voucherId = voucherId;
            dtoStockVoucher.voucherType = voucherType__;
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
                Clear_Fields();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dtoStockVoucher = new StockVoucher();
            dtoStockVoucher.voucherId = voucherId;
            if (!busStockVoucher.DeleteStockVoucher(dtoStockVoucher))
            {
                MessageBox.Show("Xóa phiếu không thành công");
                Clear_Fields();
                return;
            }
            else
            {
                MessageBox.Show("Xóa phiếu thành công");
                Load_Data();
                Clear_Fields();
            }
        }
    }
}
