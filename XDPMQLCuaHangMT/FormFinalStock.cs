using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using XDPMQLCuaHangMT.ThongKe;
namespace XDPMQLCuaHangMT
{
    public partial class FormFinalStock : Form
    {
        List<VoucherDetail> list;
        protected int employeeId__;
        protected string voucherType__, note__;
        BUS_StockVoucher busStockVoucher = new BUS_StockVoucher();
        BUS_VoucherDetail busVoucherDetail = new BUS_VoucherDetail();

        private ExcelHandle excelHandle = new ExcelHandle();
        StockVoucher stockVoucher;
        public FormFinalStock()
        {
            InitializeComponent();
        }
        public FormFinalStock(List<VoucherDetail> list, int employeeId, string voucherType, string note)
        {
            InitializeComponent();
            this.list = list;
            this.employeeId__ = employeeId;
            this.voucherType__ = voucherType;
            this.note__ = note;
        }

        private void FormFinalStock_Load(object sender, EventArgs e)
        {
            Load_Data();
            //this.reportViewer1.RefreshReport();
        }

        public void Load_Data()
        {
            var bindingList = new BindingList<VoucherDetail>(list);
            dgvExport.DataSource = bindingList;
            dgvExport.Columns["detailId"].HeaderText = "Mã chi tiết phiếu";
            dgvExport.Columns["voucherId"].HeaderText = "Mã phiếu nhập";
            dgvExport.Columns["productId"].HeaderText = "Mã sản phẩm";
            dgvExport.Columns["quantity"].HeaderText = "Số lượng";
            dgvExport.Columns["unitPrice"].HeaderText = "Đơn giá";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

            excelHandle.SaveExcel(dgvExport, "Danh sách sản phẩm trong phiếu", "Phiếu xuất nhập kho");
            int i = 0;
            int n = dgvExport.RowCount;
            stockVoucher = new StockVoucher();
            stockVoucher.voucherType = voucherType__;
            stockVoucher.createdBy = this.employeeId__;
            stockVoucher.note = "Phiếu nhập kho";
            object id = busStockVoucher.InsertStockVoucherSolid(stockVoucher);
            int voucherId_ = (int)id;

            try
            {

                foreach (VoucherDetail item in list)
                {
                    i++;
                    string type_ = voucherType__;
                    int performedBy = this.employeeId__;
                    string productName = "asd";

                    busVoucherDetail.InsertVoucherDetailSolid(item, productName, type_, voucherId_);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (voucherType__.Equals("IN"))
            {
                FormCrpPhieuNhapKho rp = new FormCrpPhieuNhapKho(voucherId_);
                rp.Show();
                rp.MaximumSize = this.MaximumSize;

            }
            else
            {
                FormCrpPhieuXuatKho rp = new FormCrpPhieuXuatKho(voucherId_);
                rp.Show();
                rp.MaximumSize = this.MaximumSize;
            }

            if (i == n)
            {
                MessageBox.Show("Xuất phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Xuất phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            i = 0;
        }
    }
}
