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
                query = "SELECT * FROM VoucherDetails";
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
                query = "SELECT * FROM VoucherDetails WHERE VoucherId = @VoucherId";
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
                query = "SELECT * FROM VoucherDetails WHERE DetailId = @DetailId";
                return ExecuteQuery(query, new object[] { detailId });
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int InsertVoucherDetail(int voucherId, int productId, int quantity, decimal unitPrice)
        {
            try
            {
                query = "INSERT INTO VoucherDetails (VoucherId, ProductId, Quantity, UnitPrice) VALUES ( @VoucherId , @ProductId , @Quantity , @UnitPrice )";
                return ExecuteNonQuery(query, new object[] { voucherId, productId, quantity, unitPrice });
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
