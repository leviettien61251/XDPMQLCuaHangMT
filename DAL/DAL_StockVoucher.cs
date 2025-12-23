using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_StockVoucher : Connect
    {
        private string query = @"";

        public DataTable GetAllStockVouchers()
        {
            try
            {
                query = "SELECT VoucherId, VoucherType as 'Loại', VoucherDate as 'Ngày nhập/xuất', CreatedBy as 'Nhân viên', Note as 'Ghi chú' FROM StockVouchers";
                return ExecuteQuery(query);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable GetStockVoucherById(int voucherId)
        {
            try
            {
                query = "SELECT * FROM StockVouchers WHERE VoucherId = @VoucherId";
                return ExecuteQuery(query, new object[] { voucherId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int InsertStockVoucher(string voucherType, int createdBy, string note)
        {
            try
            {
                query = "INSERT INTO StockVouchers (VoucherType, CreatedBy, Note) VALUES ( @VoucherType , @CreatedBy , @Note )";
                return ExecuteNonQuery(query, new object[] { voucherType, createdBy, note });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public object InsertStockVoucherSolid(string voucherType, int createdBy, string note)
        {
            try
            {
                query = "EXEC usp_InsertStockVoucher_ @VoucherType , @EmployeeId , @Note ";
                return ExecuteScalar(query, new object[] { voucherType, createdBy, note });
            }
            catch (SqlException)
            {
                throw;
            }
        }


        public int UpdateStockVoucher(int voucherId, string voucherType, string note)
        {
            try
            {
                query = "UPDATE dbo.StockVouchers SET VoucherType = @VoucherType , Note = @Note WHERE VoucherId = @VoucherId";
                return ExecuteNonQuery(query, new object[] { voucherType, note, voucherId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int DeleteStockVoucher(int voucherId)
        {
            try
            {
                query = "DELETE FROM dbo.StockVouchers WHERE VoucherId = @VoucherId";
                return ExecuteNonQuery(query, new object[] { voucherId });
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
