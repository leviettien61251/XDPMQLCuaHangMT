using BUS;
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.ThongKe
{
    public partial class FormThongKeSP : Form
    {
        public FormThongKeSP()
        {
            InitializeComponent();
        }
        protected string order = "DESC";
        protected int type = 0;
        BUS_ThongKeSanPham busThongKeSanPham = new BUS_ThongKeSanPham();

        private void FormThongKeSP_Load(object sender, EventArgs e)
        {

        }

        private void cboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cboThongKe.SelectedItem.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (cboThongKe.SelectedIndex == 0)
            {
                type = cboThongKe.SelectedIndex;
                dgvDanhSach.DataSource = busThongKeSanPham.ThongKeSanPhamTonKho(order);
            }
            else
            {
                type = cboThongKe.SelectedIndex;
                dgvDanhSach.DataSource = busThongKeSanPham.ThongKeSanPhamSapHetHang(order);
            }


        }
    }
}
