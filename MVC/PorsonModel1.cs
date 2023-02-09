namespace MVC
{
    public class PersonModel1
    {
         

        public int IdNumber { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public double phoneNumber { get; set; }

        public string? emailAddress { get; set; }
        public string? mailingAddress { get; set; }
        public string? empyeeType { get; set; }

        public int baseSalary { get; set; }
        public PersonModel1(int IdNumber, string empyeeType, string firstName, string lastName, double phoneNumber, string emailAddress, string mailingAddress, int baseSalary)
        {
            this.IdNumber = IdNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.mailingAddress = mailingAddress;
            this.empyeeType = empyeeType;
            this.baseSalary = baseSalary;
        }





    }
}