using DAL;
using DTO;
using System.Data;
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
        public DataTable SearchSupplierByName(string keywords)
        {
            return dalSupplier.SearchSupplierByName(keywords);
        }
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
