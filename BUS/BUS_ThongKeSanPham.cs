using DAL;
using System.Data;
namespace BUS
{
    public class BUS_ThongKeSanPham
    {
        DAL_ThongKeSanPham dalThongKeSanPham = new DAL_ThongKeSanPham();
        public BUS_ThongKeSanPham() { }
        public DataTable ThongKeSanPhamTonKho(string order)
        {
            return dalThongKeSanPham.ThongKeSanPhamTonKho(order);
        }
        public DataTable ThongKeSanPhamSapHetHang(string order)
        {
            return dalThongKeSanPham.ThongKeSanPhamSapHetHang(order);
        }

    }
}
