using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Supplier : Connect
    {
        private string query = @"";
        public DataTable GetAllSuppliers()
        {
            try
            {
                query = "SELECT * FROM Suppliers";
                return Load(query);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public int InsertSupplier(string name, string contactName, string phone, string email, string address)
        {
            try
            {
                query = "INSERT INTO Suppliers (Name, Contact, Phone, Email, Address) VALUES ( @Name , @Contact , @Phone , @Email , @Address )";
                return ExecuteNonQuery(query, new object[] { name, contactName, phone, email, address });
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public int UpdateSupplier(int id, string name, string contactName, string phone, string email, string address)
        {
            try
            {
                query = "UPDATE dbo.Suppliers SET Name = @Name , Contact = @Contact , Phone = @Phone , Email = @Email , Address = @Address WHERE SupplierId = @SupplierId ";
                return ExecuteNonQuery(query, new object[] { name, contactName, phone, email, address , id });
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public int DeleteSupplier(int id)
        {
            try
            {
                query = "DELETE FROM dbo.Suppliers WHERE SupplierId = @SupplierId";
                return ExecuteNonQuery(query, new object[] { id });
            }
            catch (SqlException)
            {
                throw;
            }

        }
    }
}
