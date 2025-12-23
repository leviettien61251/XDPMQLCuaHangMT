using BUS;
using DTO;
using System;
using System.Windows.Forms;
namespace XDPMQLCuaHangMT
{
    public partial class FormStockDetail : Form
    {
        protected int employeeId__, stockVoucherId__, productId__, voucherType__;
        VoucherDetail voucherDetail;
        BUS_Product busProduct = new BUS_Product();
        BUS_VoucherDetail busVoucherDetail = new BUS_VoucherDetail();
        public FormStockDetail()
        {
            InitializeComponent();
        }
        public FormStockDetail(int employeeId, int stockVoucherId, string voucherType)
        {
            InitializeComponent();
            this.employeeId__ = employeeId;
            this.stockVoucherId__ = stockVoucherId;
            this.voucherType__ = voucherType__;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string productName = textBoxProduct.Text;
            decimal productUnitPrice = decimal.Parse(textBoxUnitPrice.Text);
            int productQuantity = int.Parse(textBoxQuantity.Text);
            voucherDetail = new VoucherDetail();
            voucherDetail.voucherId = stockVoucherId__;
            voucherDetail.productId = productId__;
            voucherDetail.unitPrice = productUnitPrice;
            voucherDetail.quantity = productQuantity;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(textBoxUnitPrice.Text) || string.IsNullOrEmpty(textBoxStockQty.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (busVoucherDetail.InsertVoucherDetail(voucherDetail, employeeId__, productName, productQuantity))
            {
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProduct.Text = dgvProduct.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
            productId__ = Int32.Parse(dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString());
            textBoxUnitPrice.Text = dgvProduct.CurrentRow.Cells["Giá"].Value.ToString();
            textBoxStockQty.Text = dgvProduct.CurrentRow.Cells["Tồn kho"].Value.ToString();
        }

        private void FormStockDetail_Load(object sender, EventArgs e)
        {
            textBoxStockId.Text = stockVoucherId__.ToString();
            textBoxStockId.ReadOnly = true;
            textBoxStockQty.ReadOnly = true;
            //if ()
            //{

            //}
            labelTitle.Text = "Phiếu nhập";
            labelTitle.Text = "Phiếu xuất";
            Load_Data();
        }
        private void Load_Data()
        {
            dgvProduct.DataSource = busProduct.GetAllProducts();
            dgvDetailStock.DataSource = busVoucherDetail.GetVoucherDetailsByVoucherId(stockVoucherId__);
        }
    }
}
