using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_VoucherDetail : Connect
    {
        private string query = @"";

        public DataTable GetAllVoucherDetails()
        {
            try
            {
                query = "SELECT DetailId, VoucherId, prod.Name as 'Tên sản phẩm', prod.StockQty as 'Tồn kho', vd.UnitPrice\r\nFROM dbo.StockVoucherDetails as vd INNER JOIN dbo.Products as prod\r\nON vd.ProductId = prod.ProductId";
                return Load(query);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable GetVoucherDetailsByVoucherId(int voucherId)
        {
            try
            {
                query = "SELECT DetailId, VoucherId, prod.Name as 'Tên sản phẩm', prod.StockQty as 'Tồn kho', vd.UnitPrice\r\nFROM dbo.StockVoucherDetails as vd INNER JOIN dbo.Products as prod\r\nON vd.ProductId = prod.ProductId WHERE vd.VoucherId = @VoucherId";
                return ExecuteQuery(query, new object[] { voucherId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable GetVoucherDetailById(int detailId)
        {
            try
            {
                query = "SELECT DetailId, VoucherId, prod.Name as 'Tên sản phẩm', prod.StockQty as 'Tồn kho', vd.UnitPrice\r\nFROM dbo.StockVoucherDetails as vd INNER JOIN dbo.Products as prod\r\nON vd.ProductId = prod.ProductId WHERE vd.DetailId = @DetailId";
                return ExecuteQuery(query, new object[] { detailId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int InsertVoucherDetail(int voucherId, int performedBy, int productId, string productName, int quantity)
        {
            try
            {
                query = " EXEC usp_InsertProductToDetailVoucher @VoucherId , @PerformedBy , @ProductId , @ProductName , @Quantity ";
                return ExecuteNonQuery(query, new object[] { voucherId, performedBy, productId, productName, quantity });
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public int InsertVoucherDetailSolid(int voucherId, string type, int productId, string productName, int quantity)
        {
            try
            {
                query = "EXEC usp_InsertProductToDetailVoucherSolid @TypeForInsertVoucher , @VoucherId , @ProductId , @ProductName , @Quantity ";
                return ExecuteNonQuery(query, new object[] { type, voucherId, productId, productName, quantity });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int UpdateVoucherDetail(int detailId, int voucherId, int productId, int quantity, decimal unitPrice)
        {
            try
            {
                query = "UPDATE dbo.VoucherDetails SET VoucherId = @VoucherId , ProductId = @ProductId , Quantity = @Quantity , UnitPrice = @UnitPrice WHERE DetailId = @DetailId";
                return ExecuteNonQuery(query, new object[] { voucherId, productId, quantity, unitPrice, detailId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int DeleteVoucherDetail(int detailId)
        {
            try
            {
                query = "DELETE FROM dbo.VoucherDetails WHERE DetailId = @DetailId";
                return ExecuteNonQuery(query, new object[] { detailId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int DeleteVoucherDetailsByVoucherId(int voucherId)
        {
            try
            {
                query = "DELETE FROM dbo.VoucherDetails WHERE VoucherId = @VoucherId";
                return ExecuteNonQuery(query, new object[] { voucherId });
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
