using DTO;
using System.Data;
namespace DAL
{
    public class DAL_Employee : Connect
    {
        public DAL_Employee() { }
        string query = @"";

        public DataTable GetNameAllEmployees()
        {
            DataTable dt = new DataTable();
            query = "SELECT EmployeeId, FirstName as 'Tên', LastName as 'Họ' FROM dbo.Employees";
            dt = ExecuteQuery(query);
            return dt;
        }
        public DataTable GetAllEmployeess()
        {
            DataTable dt = new DataTable();
            query = "SELECT EmployeeId as 'Mã nhân viên', ImageURL as 'Hình ảnh', FirstName as 'Tên', LastName as 'Họ', Phone as 'Số điện thoại', Email, DeletedAt as 'Thời gian xóa', DeletedBy as 'Người thực hiện', IsActive as 'Trạng thái' FROM dbo.Employees";
            dt = ExecuteQuery(query);
            return dt;
        }
        public DataTable GetEmployeeById(int employeeId)
        {
            DataTable dt = new DataTable();
            query = "SELECT EmployeeId, FirstName as 'Tên', LastName as 'Họ', Phone as 'Số điện thoại', Email  FROM dbo.Employees WHERE EmployeeId = @employeeId";
            dt = ExecuteQuery(query, new object[] { employeeId });
            return dt;
        }
        public object GetEmployeeNameById(int employeeId)
        {
            query = "EXEC usp_GetEmployeeNameById @EmployeeId";
            return ExecuteScalar(query, new object[] { employeeId });
        }
        public DataTable SearchEmployees(string keyword)
        {
            DataTable dt = new DataTable();
            query = "EXEC usp_SearchEmployee @Searching";
            dt = ExecuteQuery(query, new object[] { keyword });
            return dt;
        }
        public int InsertEmployee(Employee employee)
        {
            query = "INSERT INTO dbo.Employees (FirstName, LastName, Phone, Email, ImageURL) VALUES ( @FirstName , @LastName , @Phone , @Email , @ImageURL )";
            int result = ExecuteNonQuery(query, new object[] { employee.firstName, employee.lastName, employee.phone, employee.email, employee.imageURL });
            return result;
        }
        public int UpdateEmployee(Employee employee)
        {
            query = "UPDATE dbo.Employees SET FirstName = @FirstName , LastName = @LastName , Phone = @Phone , Email = @Email , ImageURL = @ImageURL , IsActive = @IsActive WHERE EmployeeId = @employeeId ";
            int result = ExecuteNonQuery(query, new object[] { employee.firstName, employee.lastName, employee.phone, employee.email, employee.imageURL, employee.isActive, employee.employeeId });
            return result;
        }
        public int DeleteEmployee(int employeeId)
        {
            query = "DELETE FROM dbo.Employees WHERE EmployeeId = @employeeId ";
            int result = ExecuteNonQuery(query, new object[] { employeeId });
            return result;
        }
        public int SoftDeleteEmployee(int employeeId)
        {
            query = "UPDATE dbo.Employees SET IsActive = 0 WHERE EmployeeId = @employeeId ";
            int result = ExecuteNonQuery(query, new object[] { employeeId });
            return result;
        }
    }
}
