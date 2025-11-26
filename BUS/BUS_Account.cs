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
    public class BUS_Account
    {
        DAL_Account dalAccount = new DAL_Account();
        public DataTable Login(Account account)
        {
            return dalAccount.Login(account.username, account.password);
        }


    }
}
