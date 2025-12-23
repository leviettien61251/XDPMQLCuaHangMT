namespace DTO
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string name { get; set; }
        public string contactName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public Supplier() { }

        public Supplier(int supplierID, string name, string contactName, string phone, string email, string address)
        {
            this.supplierID = supplierID;
            this.name = name;
            this.contactName = contactName;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }

        public Supplier(string name, string contactName, string phone, string email, string address)
        {
            this.name = name;
            this.contactName = contactName;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
    }
}
