using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product : Connect
    {
        public DataTable GetAllProducts()
        {
            try
            {
                string query = "SELECT ProductId as 'Mã sản phẩm', prod.Name as 'Tên sản phẩm', sup.Name as 'Nhà cung cấp', prod.Unit as 'Đơn vị', prod.UnitPrice as 'Giá', prod.StockQty as 'Tồn kho' \r\nFROM dbo.Products as prod INNER JOIN dbo.Suppliers as sup\r\nON prod.SupplierId = sup.SupplierId ";
                return ExecuteQuery(query);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable FindProducts(string searching)
        {
            try
            {
                string query = "EXEC usp_SearhProductByName @Searching";
                return ExecuteQuery(query, new object[] { searching });
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
