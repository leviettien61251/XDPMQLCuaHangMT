using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable GetAllEmployeess()
        {
            return dalEmployee.GetAllEmployeess();
        }

        public bool InsertEmployee(Employee employee)
        {
            int result = dalEmployee.InsertEmployee(employee);
            return result > 0;
        }
        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                int result = dalEmployee.UpdateEmployee(employee);
                return result > 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            
        }
        public bool DeleteEmployee(int employeeId)
        {
            int result = dalEmployee.DeleteEmployee(employeeId);
            return result > 0;
        }
    }
}
