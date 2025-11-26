using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account : Connect
    {
        private string query = @"";

        public DAL_Account() { }

        public DataTable Login(string username, string password)
        {
            query = "SELECT  RoleId, EmployeeId, CreatedAt, Username, PasswordHash FROM dbo.Accounts WHERE Username = @Username AND PasswordHash = @Password";

            DataTable dt = ExecuteQuery(query, new object[] { username, password });

            return dt;
        }
    }
}
