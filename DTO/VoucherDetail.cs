namespace DTO
{
    public class VoucherDetail
    {
        public int detailId { get; set; }
        public int voucherId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }//Tổng giá trị mỗi mặt hàng.
        public VoucherDetail() { }
        public VoucherDetail(int detailId, int voucherId, int productId, int quantity, decimal unitPrice)
        {
            this.detailId = detailId;
            this.voucherId = voucherId;
            this.productId = productId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }
    }
}
