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
    public class BUS_Role
    {
        DAL_Role dalRole = new DAL_Role();
        Role dtoRole = new Role();
        public BUS_Role() { }

        public DataTable GetAllRoles()
        {
            return dalRole.GetAllRole();
        }
    }
}
