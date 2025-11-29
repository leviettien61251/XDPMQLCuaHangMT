using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Employee : Connect
    {
        public DAL_Employee() { }
        string query = @"";

        public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            query = "SELECT EmployeeId, FullName FROM dbo.Employees";
            dt = ExecuteQuery(query);
            return dt;
        }
    }
}
