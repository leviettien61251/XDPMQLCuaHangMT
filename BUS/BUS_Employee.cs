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
    public class BUS_Employee
    {
        DAL_Employee dalEmployee = new DAL_Employee();
        public BUS_Employee() { }

        public DataTable GetAllEmployees()
        {
            return dalEmployee.GetAllEmployees();
        }
    }
}
