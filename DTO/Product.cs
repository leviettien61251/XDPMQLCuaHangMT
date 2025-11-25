using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int productId { get; set; }
        public string SKU { get; set; } //Stock Keeping Unit
        public string productName { get; set; }
        public int supplierId { get; set; }
        public string unit { get; set; }
        public decimal unitPrice { get; set; }
        public decimal costPrice { get; set; }
        public int stockQuantity { get; set; }
        public int minThreshold { get; set; }

        public Product() { }
        public Product(int productId, string SKU, string productName, int supplierId, string unit, decimal unitPrice, decimal costPrice, int stockQuantity, int minThreshold)
        {
            this.productId = productId;
            this.SKU = SKU;
            this.productName = productName;
            this.supplierId = supplierId;
            this.unit = unit;
            this.unitPrice = unitPrice;
            this.costPrice = costPrice;
            this.stockQuantity = stockQuantity;
            this.minThreshold = minThreshold;
        }

        public Product(int productId, string SKU, string productName, int supplierId, string unit, decimal unitPrice, decimal costPrice)
        {
            this.productId = productId;
            this.SKU = SKU;
            this.productName = productName;
            this.supplierId = supplierId;
            this.unit = unit;
            this.unitPrice = unitPrice;
            this.costPrice = costPrice;
        }

    }
}
