// AccountForm.cs
using System;
using System.Reflection;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

            // Gán placeholder an toàn (nếu TextBox hỗ trợ PlaceholderText)
            var prop = this.txtSearch?.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearch, "Tìm kiếm theo username hoặc nhân viên");
            }

            // Gắn event handlers ở đây nếu cần (bạn đã có logic riêng)
            // btnAdd.Click += BtnAdd_Click;
            // btnEdit.Click += BtnEdit_Click;
            // btnDelete.Click += BtnDelete_Click;
            // btnSearch.Click += BtnSearch_Click;
        }
    }
}