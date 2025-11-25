using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Supplier
    {


        DAL.DAL_Supplier dalSupplier = new DAL.DAL_Supplier();
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

        public bool UpdateSupplier(int id, string name, string contactName, string phone, string email, string address)
        {
            int rowAffected = dalSupplier.UpdateSupplier(id, name, contactName, phone, email, address);
            return rowAffected > 0;
        }
    }
}
