using System.Data;
using System.Data.SqlClient;

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
        public DataTable GetAllAccounts()
        {
            query = "SELECT AccountId as 'Mã tài khoản', Username as 'Tên đăng nhập', RoleName as 'Chức vụ', EmployeeId as 'Mã nhân viên', CreatedAt as 'Tạo lúc', IsActive as 'Trạng thái' FROM dbo.Accounts as a INNER JOIN dbo.Roles as r ON a.RoleId = r.RoleId";
            try
            {
                DataTable dt = ExecuteQuery(query);
                return dt;
            }
            catch (SqlException ex)
            {
                return new DataTable();
                throw ex;
            }
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
        public int UpdateAccount(string username, string passwordHash, int roleId, int employeeId)
        {
            query = "UPDATE dbo.Accounts SET PasswordHash = @PasswordHash , RoleId = @RoleId , EmployeeId = @EmployeeId WHERE Username = @Username ";
            try
            {
                int result = ExecuteNonQuery(query, new object[] { passwordHash, roleId, employeeId, username });
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchingAccounts(string keywords)
        {
            DataTable dt = new DataTable();
            query = "EXEC usp_SearchAccountByUserName @Searching";
            try
            {
                dt = ExecuteQuery(query, new object[] { keywords });
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
