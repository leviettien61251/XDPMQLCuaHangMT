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
    public partial class FormCrpTongHopTonKho : Form
    {
        public FormCrpTongHopTonKho()
        {
            InitializeComponent();
        }
        public FormCrpTongHopTonKho(string begin, string end)
        {
            InitializeComponent();
            this.beginDate = begin;
            this.endDate = end;
        }
        protected string beginDate, endDate;
        BUS_ThongKeSanPham busThongKeSanPham = new BUS_ThongKeSanPham();

        private void FormCrpTongHopTonKho_Load(object sender, EventArgs e)
        {
                Load_Report();
        }

        private void Load_Report()
        {
            DataTable dt = busThongKeSanPham.ThongKeSanPhamTonKhoTheoKy(beginDate, endDate);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CrystalReportTongHopKho rp = new CrystalReportTongHopKho();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
    }
}
