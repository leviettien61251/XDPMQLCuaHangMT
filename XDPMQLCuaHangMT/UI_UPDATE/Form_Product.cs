// ProductForm.cs
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            // Gán placeholder an toàn cho txtSearch nếu control hỗ trợ
            var prop = this.txtSearchSupplier?.GetType().GetProperty("PlaceholderText");
            if (prop != null)
            {
                prop.SetValue(this.txtSearchSupplier, "Tìm kiếm theo tên sản phẩm hoặc nhà cung cấp");
            }

            // Gắn event handlers tại đây nếu cần
            // btnAdd.Click += BtnAdd_Click;
            // btnEdit.Click += BtnEdit_Click;
            // btnDelete.Click += BtnDelete_Click;
            // btnSearch.Click += BtnSearch_Click;
        }

        // Bạn tự triển khai các handler theo logic hiện có.
    }
}