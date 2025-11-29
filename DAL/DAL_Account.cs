using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account : Connect
    {
        private string query = @"";

        public DAL_Account() { }

        public DataTable Login(string username)
        {
            query = "SELECT  RoleId, EmployeeId, CreatedAt, Username, PasswordHash FROM dbo.Accounts WHERE Username = @Username ";

            DataTable dt = ExecuteQuery(query, new object[] { username });

            return dt;
        }

        public int InsertAccount(string username, string passwordHash, int roleId, int employeeId)
        {
            query = "INSERT INTO dbo.Accounts (Username, PasswordHash, RoleId, EmployeeId) VALUES ( @Username , @PasswordHash , @RoleId , @EmployeeId )";
            
            try
            {
                int result = ExecuteNonQuery(query, new object[] { username, passwordHash, roleId, employeeId });
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            

        }
    }
}
