namespace DTO
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string isActive { get; set; }
        public string deletedAt { get; set; }
        public string deletedBy { get; set; }
        public string imageURL { get; set; }
        public string lastName { get; set; }
        public Employee()
        {
        }
        public Employee(int employeeId, string firstName, string lastName, string phone, string email, string isActive, string deletedAt, string deletedBy, string imageURL)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.phone = phone;
            this.email = email;
            this.isActive = isActive;
            this.deletedAt = deletedAt;
            this.deletedBy = deletedBy;
            this.imageURL = imageURL;
        }
        public Employee(int employeeId, string firstName, string lastName, string phone, string email, string isActive)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.phone = phone;
            this.email = email;
            this.isActive = isActive;
            this.lastName = lastName;
        }
    }
}
