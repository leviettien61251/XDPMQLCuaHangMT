using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public string deletedAt { get; set; }
        public string deletedBy { get; set; }
        public string imageURL { get; set; }
        public Employee()
        {
        }
        public Employee(int employeeId, string fullName, string phone, string email, bool isActive, string deletedAt, string deletedBy, string imageURL)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.phone = phone;
            this.email = email;
            this.isActive = isActive;
            this.deletedAt = deletedAt;
            this.deletedBy = deletedBy;
            this.imageURL = imageURL;
        }
        public Employee(int employeeId, string fullName, string phone, string email, bool isActive)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.phone = phone;
            this.email = email;
            this.isActive = isActive;
        }
    }
}
