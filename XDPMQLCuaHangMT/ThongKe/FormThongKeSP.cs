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
            // Use Custom format and uppercase MM for month (mm = minutes)
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
        }

        private void cboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cboThongKe.SelectedItem.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string beginDate, endDate;
                // Format dates as dd/MM/yyyy to match stored procedure expectations
                beginDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                endDate = dateTimePicker2.Value.ToString("yyyy/MM/dd");

                if (cboThongKe.SelectedIndex == 0)
                {
                    type = cboThongKe.SelectedIndex;
                    dgvDanhSach.DataSource = busThongKeSanPham.ThongKeSanPhamTonKho(order);
                }
                else if(cboThongKe.SelectedIndex == 1)
                {
                    type = cboThongKe.SelectedIndex;
                    dgvDanhSach.DataSource = busThongKeSanPham.ThongKeSanPhamSapHetHang(order);
                } 
                else if(cboThongKe.SelectedIndex == 2)
                {
                    type = cboThongKe.SelectedIndex;
                    FormCrpTongHopTonKho rp = new FormCrpTongHopTonKho(beginDate, endDate);
                    rp.Show();
                    rp.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
