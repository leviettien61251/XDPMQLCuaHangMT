using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        public FormStock(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }
        protected int employeeId, voucherId;
        protected string voucherType__;
        StockVoucher dtoStockVoucher;
        DataTable dtEmployee;
        BUS_StockVoucher busStockVoucher = new BUS_StockVoucher();
        BUS_Employee busEmployee = new BUS_Employee();
        private void buttonStockDetial_Click(object sender, EventArgs e)
        {
            //FormStockDetail formStockDetail = new FormStockDetail(employeeId, voucherId, voucherType);
            //formStockDetail.ShowDialog();
            //formStockDetail.WindowState = FormWindowState.Maximized;
            //formStockDetail.BringToFront();
            //if (voucherType__ != "IN")
            //{

            //    FormVoucherOUT formVoucherOUT = new FormVoucherOUT(employeeId, voucherId, voucherType__);
            //    formVoucherOUT.ShowDialog();
            //    formVoucherOUT.WindowState = FormWindowState.Maximized;
            //    formVoucherOUT.BringToFront();
            //}
            //else
            //{
            //    FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, voucherId, voucherType__);
            //    formVoucherIN.ShowDialog();
            //    formVoucherIN.WindowState = FormWindowState.Maximized;
            //    formVoucherIN.BringToFront();
            //}
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
            voucherType__ = dgvStock.CurrentRow.Cells["Loại"].Value.ToString().Trim();
            comboBoxStockType.Text = dgvStock.CurrentRow.Cells["Loại"].Value.ToString();
            textBoxDate.Text = dgvStock.CurrentRow.Cells["Ngày nhập/xuất"].Value.ToString();
            textBoxNote.Text = dgvStock.CurrentRow.Cells["Ghi chú"].Value.ToString();
            labelStockId.Text = "Mã phiếu: " + dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString();
            voucherId = Int32.Parse(dgvStock.CurrentRow.Cells["VoucherId"].Value.ToString());
        }

        private void comboBoxStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            voucherType__ = comboBoxStockType.Text.ToString();
        }
        private void Clear_Fields()
        {
            comboBoxStockType.Text = "";
            textBoxDate.Text = "";
            textBoxNote.Text = "";
            labelStockId.Text = "Mã phiếu: ";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int createdBy = employeeId;
            string notes = textBoxNote.Text.ToString();

            if (string.IsNullOrEmpty(voucherType__))
            {
                MessageBox.Show("Vui lòng chọn loại phiếu");
                return;
            }
            dtoStockVoucher = new StockVoucher(voucherType__, createdBy, notes);
            //if (!busStockVoucher.InsertStockVoucher(dtoStockVoucher))
            //{
            //    MessageBox.Show("Thêm phiếu không thành công");
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Thêm phiếu thành công");
            //    Load_Data();
            //    voucherId = dgvStock.Rows[dgvStock.Rows.Count - 1].Cells["VoucherId"].Value != null ?
            //                Int32.Parse(dgvStock.Rows[dgvStock.Rows.Count - 1].Cells["VoucherId"].Value.ToString()) : 0;
            //if (voucherType__ != "IN")
            //{

            //    FormVoucherOUT formVoucherOUT = new FormVoucherOUT(employeeId, dtoStockVoucher.note);
            //    formVoucherOUT.ShowDialog();
            //    formVoucherOUT.WindowState = FormWindowState.Maximized;
            //    formVoucherOUT.BringToFront();
            //}
            //else
            //{
            //    FormVoucherDetail formVoucherIN = new FormVoucherDetail(employeeId, dtoStockVoucher.note);
            //    formVoucherIN.ShowDialog();
            //    formVoucherIN.WindowState = FormWindowState.Maximized;
            //    formVoucherIN.BringToFront();
            //}

        }


        //}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string notes = textBoxNote.Text.ToString();

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
