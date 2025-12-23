// SupplierForm.cs
using System;
using System.Reflection;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            // Gán placeholder an toàn cho txtSearch (nếu TextBox hỗ trợ PlaceholderText)
            var prop = this.txtSearch?.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearch, "Tìm kiếm theo tên hoặc số điện thoại");
            }

            // Gắn event handlers tại đây nếu cần (UI-only)
            // btnAdd.Click += BtnAdd_Click;
            // btnEdit.Click += BtnEdit_Click;
            // btnDelete.Click += BtnDelete_Click;
            // btnSearch.Click += BtnSearch_Click;
        }

        private void grpForm_Enter(object sender, EventArgs e)
        {

        }

        // Bạn tự triển khai các handler theo logic hiện có.
    }
}