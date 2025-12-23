namespace DTO
{
    public class StockVoucher
    {
        public int voucherId { get; set; }
        public string voucherType { get; set; }
        public string voucherDate { get; set; }
        public int createdBy { get; set; }
        public string note { get; set; }
        public StockVoucher() { }
        public StockVoucher(int voucherId, string voucherType, string voucherDate, int createdBy, string note)
        {
            this.voucherId = voucherId;
            this.voucherType = voucherType;
            this.voucherDate = voucherDate;
            this.createdBy = createdBy;
            this.note = note;
        }
        public StockVoucher(int voucherId, string voucherType, string voucherDate, string note)
        {
            this.voucherId = voucherId;
            this.voucherType = voucherType;
            this.voucherDate = voucherDate;
            this.note = note;
        }

        public StockVoucher(string voucherType, int createdBy, string note)
        {
            this.voucherType = voucherType;
            this.createdBy = createdBy;
            this.note = note;
        }
    }
}
