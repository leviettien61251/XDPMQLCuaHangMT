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
    public partial class FormCrpPhieuXuatKho : Form
    {
        public FormCrpPhieuXuatKho()
        {
            InitializeComponent();
        }
        public FormCrpPhieuXuatKho(int id)
        {
            InitializeComponent();
            this.voucherId__ = id;
        }
        protected int voucherId__;
        BUS_ThongKePhieu busThongKePhieu = new BUS_ThongKePhieu();
        private void FormCrpPhieuXuatKho_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.Refresh();
            Load_Report();
        }
        private void Load_Report()
        {
            DataTable dt = busThongKePhieu.GetVoucherDetailsByVoucherId(voucherId__);

            CrystalReportPhieuXuatKho rpt = new CrystalReportPhieuXuatKho();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
