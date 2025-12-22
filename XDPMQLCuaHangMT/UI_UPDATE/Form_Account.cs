// AccountForm.cs
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    // Lớp chính: phải kế thừa Form và là partial để ghép với Designer
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

            // Gán placeholder an toàn bằng reflection ngoài InitializeComponent
            var prop = this.txtSearch.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearch, "Tìm kiếm theo tên hoặc username");
            }
        }
    }
}