using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Product
    {
        DAL_Product dalProduct = new DAL_Product();
        public DataTable GetAllProducts()
        {
            try
            {
                return dalProduct.GetAllProducts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable FindProducts(string searching)
        {
            try
            {
                return dalProduct.FindProducts(searching);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
