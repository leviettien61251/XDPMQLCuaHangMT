using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormVoucherOUT : Form
    {
        protected int employeeId__, stockVoucherId__, productId__, voucherType__;
        protected string productName__;
        VoucherDetail voucherDetail;
        BUS_Product busProduct = new BUS_Product();
        BUS_VoucherDetail busVoucherDetail = new BUS_VoucherDetail();
        List<VoucherDetail> productList = new List<VoucherDetail>();
        public FormVoucherOUT()
        {
            InitializeComponent();
        }
        public FormVoucherOUT(int employeeId, int stockVoucherId, string voucherType)
        {
            InitializeComponent();
            this.employeeId__ = employeeId;
            this.stockVoucherId__ = stockVoucherId;
            this.voucherType__ = voucherType__;
        }
    }
}
