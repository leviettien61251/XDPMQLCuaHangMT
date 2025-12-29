using DAL;
namespace BUS
{
    public class BUS_ThongKePhieu
    {
        DAL_ThongKePhieu dalThongKePhieu = new DAL_ThongKePhieu();
        public BUS_ThongKePhieu() { }
        public System.Data.DataTable ThongKePhieuNhap(string type, string beginDate, string endDate)
        {
            return dalThongKePhieu.ThongKePhieuNhap(type, beginDate, endDate);
        }
    }
}
