using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
            query = "SELECT EmployeeId, ImageURL, FirstName as 'Tên', LastName as 'Họ', Phone as 'Số điện thoại', Email, DeletedAt, DeletedBy FROM dbo.Employees";
            dt = ExecuteQuery(query);
            return dt;
        }
        public DataTable GetEmployeeById(int employeeId)
        {
            DataTable dt = new DataTable();
            query = "SELECT EmployeeId, FirstName as 'Tên', LastName as 'Họ', Phone as 'Số điện thoại', Email  FROM dbo.Employees WHERE EmployeeId = @employeeId";
            dt = ExecuteQuery(query, new object[] {employeeId});
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
            query = "UPDATE dbo.Employees SET FirstName = @FirstName , LastName = @LastName , Phone = @Phone , Email = @Email , ImageURL = @ImageURL WHERE EmployeeId = @employeeId ";
            int result = ExecuteNonQuery(query, new object[] { employee.firstName, employee.lastName, employee.phone, employee.email, employee.imageURL, employee.employeeId });
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
