using BUS;
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.ThongKe
{
    public partial class FormThongKePhieu : Form
    {
        public FormThongKePhieu()
        {
            InitializeComponent();
        }
        protected string type = "", beginDate, endDate;
        BUS_ThongKePhieu busThongKePhieu = new BUS_ThongKePhieu();
        private void FormThongKePhieu_Load(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            dgvPhieu.DataSource = busThongKePhieu.ThongKePhieuNhap(type, beginDate, endDate);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                type = "IN";
                beginDate = dateTimePickerBegin.Value.ToString("yyyy-MM-dd");
                //dgvPhieu.DataSource = busThongKePhieu.ThongKePhieuNhap(type, beginDate, endDate);
            }
            else
            {
                type = "OUT";
                endDate = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");
                //dgvPhieu.DataSource = busThongKePhieu.ThongKePhieuNhap(type, beginDate, endDate);
            }
        }
    }
}
