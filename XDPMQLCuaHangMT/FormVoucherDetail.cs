using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormVoucherDetail : Form
    {
        protected int employeeId__, stockVoucherId__, productId__, productStockQty__;
        protected string productName__, voucherType__, note__;
        VoucherDetail voucherDetail;
        BUS_Product busProduct = new BUS_Product();
        BUS_VoucherDetail busVoucherDetail = new BUS_VoucherDetail();
        List<VoucherDetail> productList = new List<VoucherDetail>();
        public FormVoucherDetail()
        {
            InitializeComponent();
        }
        public FormVoucherDetail(int employeeId, string type, string note)
        {
            InitializeComponent();
            this.employeeId__ = employeeId;
            isInOut(type);
            this.note__ = note;
        }
        public FormVoucherDetail(int employeeId, int stockVoucherId, string note, string type)
        {
            InitializeComponent();
            this.employeeId__ = employeeId;
            this.stockVoucherId__ = stockVoucherId;
            isInOut(type);
            this.note__ = note;
        }
        private void isInOut(string type)
        {
            if (type.Equals("IN"))
            {
                this.voucherType__ = "IN";
                this.Text = "Phiếu nhập";
                labelVoucherId.Text = "Mã phiếu nhập: ";
            }
            else
            {
                this.voucherType__ = "OUT";
                this.Text = "Phiếu xuất";
                labelVoucherId.Text = "Mã phiếu xuất: ";
            }
        }
        private void FormVoucherIN_Load(object sender, EventArgs e)
        {
            textBoxVoucherId.Text = stockVoucherId__.ToString();
            Load_Data();
        }
        private void Clear_InputFields()
        {
            textBoxQuantity.Clear();
            productList.Clear();
        }
        private void Load_Data()
        {
            dgvProduct.DataSource = busProduct.GetAllProducts();
        }
        private void Load_ProductsToDetail()
        {
            var bindingList = new BindingList<VoucherDetail>(productList);
            dgvDetailProduct.DataSource = bindingList;
            dgvDetailProduct.Columns["detailId"].HeaderText = "Mã chi tiết phiếu";
            dgvDetailProduct.Columns["voucherId"].HeaderText = "Mã phiếu nhập";
            dgvDetailProduct.Columns["productId"].HeaderText = "Mã sản phẩm";
            dgvDetailProduct.Columns["quantity"].HeaderText = "Số lượng";

        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productId__ = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Mã sản phẩm"].Value);
            productName__ = dgvProduct.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
            productStockQty__ = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Tồn kho"].Value);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormFinalStock formFinalStock = new FormFinalStock(productList, employeeId__, voucherType__, note__);
            formFinalStock.ShowDialog();
        }
        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchProduct.Text;
            dgvProduct.DataSource = busProduct.FindProducts(searchText);
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchProduct.Text;
            dgvProduct.DataSource = busProduct.FindProducts(searchText);
        }
        private void buttonAddProductToDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity__ = Convert.ToInt32(textBoxQuantity.Text);

            if (this.voucherType__.Equals("OUT") && quantity__ <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.voucherType__.Equals("OUT"))
            {
                if (quantity__ > productStockQty__)
                {
                    MessageBox.Show("Số lượng tồn kho không đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            voucherDetail = new VoucherDetail();
            voucherDetail.productId = productId__;
            voucherDetail.voucherId = stockVoucherId__;
            voucherDetail.quantity = quantity__;
            MessageBox.Show("Xác nhận chọn sản phẩm: " + productName__, "Thông báo", MessageBoxButtons.OKCancel);
            productList.Add(voucherDetail);
            Load_ProductsToDetail();
        }
        private void buttonRemoveProductFromDetail_Click(object sender, EventArgs e)
        {
            productList.RemoveAt(dgvDetailProduct.CurrentCell.RowIndex);
            Load_ProductsToDetail();
        }
    }
}
