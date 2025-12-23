// EmployeeForm.cs
using System;
using System.Reflection;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            // Gán placeholder an toàn (nếu TextBox hỗ trợ PlaceholderText)
            var prop = this.txtSearch?.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearch, "Tìm kiếm theo tên hoặc email");
            }

            // Ví dụ: gắn event handlers (bạn sẽ triển khai logic riêng)
            // btnAdd.Click += BtnAdd_Click;
            // btnEdit.Click += BtnEdit_Click;
            // btnDelete.Click += BtnDelete_Click;
            // btnUploadImage.Click += BtnUploadImage_Click;
        }

        // Bạn tự triển khai các handler theo logic hiện có.
    }
}