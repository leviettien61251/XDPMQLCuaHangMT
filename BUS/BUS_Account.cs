using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Account
    {
        DAL_Account dalAccount = new DAL_Account();
        DAL_Role dalRole = new DAL_Role();
        DAL_Employee dalEmployee = new DAL_Employee();

        public DataTable Login(Account account)
        {

            if (account == null) throw new ArgumentNullException(nameof(account));

            DataTable dt = dalAccount.Login(account.username);
            if (dt == null || dt.Rows.Count == 0)
                return new DataTable(); // username not found
            string storedHash = dt.Rows[0]["PasswordHash"]?.ToString();
            bool ok = PasswordHash.VerifyPassword(storedHash, account.password);
            if (!ok)
                return new DataTable(); // invalid password

            return dt; // authenticated


        }

        public bool InsertAccount(Account account)
        {
            int rowAffected = dalAccount.InsertAccount(account.username, account.password, account.roleId, account.employeeId);
            return rowAffected > 0;
        }
        public DataTable GetAllAccounts()
        {
            return dalAccount.GetAllAccounts();
        }
        public DataTable GetAllRoles()
        {
            return dalRole.GetAllRole();
        }

        public DataTable GetAllEmployees()
        {
            return dalEmployee.GetAllEmployeess();
        }

    }
}
