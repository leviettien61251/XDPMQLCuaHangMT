using BUS;
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
    public partial class FormCrpPhieuNhapKho : Form
    {
        public FormCrpPhieuNhapKho()
        {
            InitializeComponent();
        }
        public FormCrpPhieuNhapKho(int id)
        {
            InitializeComponent();
            this.voucherId_ = id;
        }
        protected int voucherId_;
        BUS_ThongKePhieu busThongKePhieu = new BUS_ThongKePhieu();
        private void FormCrpPhieuNhapKho_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            Load_Report();
        }
        private void Load_Report()
        {
            DataTable phieuNhap = busThongKePhieu.GetVoucherDetailsByVoucherId(voucherId_);
            CrystalReportPhieuNhapKho rpt = new CrystalReportPhieuNhapKho();
            rpt.SetDataSource(phieuNhap);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
