using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account : Connect
    {
        private string query = @"";

        public DAL_Account() { }

        public bool Login(string username, string password)
        {
            query = "SELECT Username, PasswordHash FROM dbo.Accounts WHERE Username = @Username AND PasswordHash = @Password";
            
            ExecuteQuery(query, new object[] { });

            return false;
        }
    }
}
