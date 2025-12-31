using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.ThongKe
{
    public partial class FormRpPhieuXuatKho : Form
    {
        public FormRpPhieuXuatKho()
        {
            InitializeComponent();
        }
        public FormRpPhieuXuatKho(int id)
        {
            InitializeComponent();
            this.voucherId_ = id;
        }
        protected int voucherId_;
        BUS_ThongKePhieu busThongKePhieu = new BUS_ThongKePhieu();
        private void ForMRpPhieuXuatKho_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            Load_Data();
        }

        private void Load_Data()
        {
            DataTable dataTable = busThongKePhieu.GetVoucherDetailsByVoucherId(voucherId_);
            try
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("GetPhieuXuatKho", dataTable);
                this.reportViewer1.LocalReport.DataSources.Add(rp);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
