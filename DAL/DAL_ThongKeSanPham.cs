using System.Data;

namespace DAL
{
    public class DAL_ThongKeSanPham : Connect
    {
        public DataTable ThongKeSanPhamTonKho(string order)
        {
            string query = "EXEC usp_ThongKeSanPhamTonKho @Order";
            return ExecuteQuery(query, new object[] { order });
        }

        public DataTable ThongKeSanPhamSapHetHang(string order)
        {
            string query = "EXEC usp_ThongKeSanPhamSapHetHang @Order";
            return ExecuteQuery(query, new object[] { order });
        }
    }
}
