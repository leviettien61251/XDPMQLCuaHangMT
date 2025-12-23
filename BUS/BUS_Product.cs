using DAL;
using System;
using System.Data;
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
