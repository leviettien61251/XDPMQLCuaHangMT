using System.Data;

namespace DAL
{
    public class DAL_ThongKePhieu : Connect
    {
        public DAL_ThongKePhieu() { }
        public DataTable ThongKePhieuNhap(string type, string beginDate, string endDate)
        {
            string query = "EXEC usp_ThongKePhieu @Type , @BeginDate , @EndDate ";
            return ExecuteQuery(query, new object[] { type, beginDate, endDate });
        }

        public DataTable GetVoucherDetailsByVoucherId2(int id)
        {
            string query = @"SELECT 
                            prod.Name,
                            prod.ProductId,
                            prod.Unit,
                            vd.Quantity,
                            vd.UnitPrice,
                            (vd.Quantity * vd.UnitPrice) as Column1
                            FROM dbo.StockVoucherDetails as vd 
                            INNER JOIN dbo.Products as prod ON vd.ProductId = prod.ProductId 
                            WHERE vd.VoucherId = @VoucherId
                            ORDER BY vd.DetailId";
            return ExecuteQuery(query, new object[] { id });
        }
        public DataTable GetVoucherDetailsByVoucherId(int id)
        {
            string query = "EXEC usp_GetVoucherDetailsByVoucherId @VoucherId";
            return ExecuteQuery(query, new object[] { id });
        }
    }
}
