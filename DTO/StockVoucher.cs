using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StockVoucher
    {
        public int voucherId { get; set; }
        public string voucherType { get; set; }
        public string voucherDate { get; set; }
        public int supplierId { get; set; }
        public string createdBy { get; set; }
        public string notes { get; set; }
        public StockVoucher() { }
        public StockVoucher(int voucherId, string voucherType, string voucherDate, int supplierId, string createdBy, string notes)
        {
            this.voucherId = voucherId;
            this.voucherType = voucherType;
            this.voucherDate = voucherDate;
            this.supplierId = supplierId;
            this.createdBy = createdBy;
            this.notes = notes;
        }
        public StockVoucher(int voucherId, string voucherType, string voucherDate, int supplierId, string notes)
        {
            this.voucherId = voucherId;
            this.voucherType = voucherType;
            this.voucherDate = voucherDate;
            this.supplierId = supplierId;
            this.notes = notes;
        }

    }
}
