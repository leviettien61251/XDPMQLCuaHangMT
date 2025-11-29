using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Supplier
    {


        DAL_Supplier dalSupplier = new DAL_Supplier();
        public BUS_Supplier() { }
        public DataTable GetAllSuppliers()
        {
            return dalSupplier.GetAllSuppliers();
        }
        //string name, string contactName, string phone, string email, string address
        public bool InsertSupplier(Supplier supplier)
        {
            int rowAffected = dalSupplier.InsertSupplier(supplier.name, supplier.contactName, supplier.phone, supplier.email, supplier.address);
            return rowAffected > 0;
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            int rowAffected = dalSupplier.UpdateSupplier(supplier.supplierID, supplier.name, supplier.contactName, supplier.phone, supplier.email, supplier.address);
            return rowAffected > 0;
        }
        public bool DeleteSupplier(Supplier supplier)
        {
            int rowAffected = dalSupplier.DeleteSupplier(supplier.supplierID);
            return rowAffected > 0;
        }
    }
}
