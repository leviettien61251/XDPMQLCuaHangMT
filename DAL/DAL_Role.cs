using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Role : Connect
    {
        string query = @"";
        public DAL_Role() { }
        public DataTable GetAllRole()
        {
            DataTable dt = new DataTable();
            query = "SELECT RoleId, RoleName FROM dbo.Roles";

            dt = ExecuteQuery(query);

            return dt;
        }
    }
}
