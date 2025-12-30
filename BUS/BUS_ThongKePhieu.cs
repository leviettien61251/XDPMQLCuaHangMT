using DAL;
using System.Data;
namespace BUS
{
    public class BUS_ThongKePhieu
    {
        DAL_ThongKePhieu dalThongKePhieu = new DAL_ThongKePhieu();
        public BUS_ThongKePhieu() { }
        public DataTable ThongKePhieuNhap(string type, string beginDate, string endDate)
        {
            return dalThongKePhieu.ThongKePhieuNhap(type, beginDate, endDate);
        }
        public DataTable GetVoucherDetailsByVoucherId(int id)
        {
            return dalThongKePhieu.GetVoucherDetailsByVoucherId(id);
        }
    }
}
