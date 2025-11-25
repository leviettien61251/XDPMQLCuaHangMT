using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        public int roleId { get; set; }
        public string roleName { get; set; }
        public Role() { }
        public Role(int roleId, string roleName)
        {
            this.roleId = roleId;
            this.roleName = roleName;
        }
    }
}
