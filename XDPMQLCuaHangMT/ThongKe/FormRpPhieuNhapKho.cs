using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.ThongKe
{
    public partial class FormRpPhieuNhapKho : Form
    {
        public FormRpPhieuNhapKho()
        {
            InitializeComponent();
        }
        public FormRpPhieuNhapKho(int id)
        {
            InitializeComponent();
            this.voucherId_ = id;
        }
        protected int voucherId_;
        BUS_ThongKePhieu busThongKePhieu = new BUS_ThongKePhieu();
        
        private void FormRpPhieuXuatKho_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable phieuNhap = busThongKePhieu.GetVoucherDetailsByVoucherId(voucherId_);

                if (phieuNhap == null || phieuNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ReportDataSource reportDataSource = new ReportDataSource("GetPhieuNhapKho", phieuNhap);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
