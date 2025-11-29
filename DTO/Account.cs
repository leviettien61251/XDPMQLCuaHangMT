using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int accountId { get; set; }
        public int employeeId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public bool isActive { get; set; }
        public string createdAt { get; set; }

        public Account() { }

        public Account(int accountId, int employeeId, string username, string password, int roleId, bool isActive, string createdAt)
        {
            this.accountId = accountId;
            this.employeeId = employeeId;
            this.username = username;
            this.password = password;
            this.roleId = roleId;
            this.isActive = isActive;
            this.createdAt = createdAt;
        }

        public Account(int accountId, int employeeId, string username, string password, int roleId)
        {
            this.accountId = accountId;
            this.employeeId = employeeId;
            this.username = username;
            this.password = password;
            this.roleId = roleId;
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
