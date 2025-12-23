using DAL;
using DTO;
using System.Data;
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
