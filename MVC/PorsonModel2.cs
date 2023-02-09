internal class PorsonModel
{
    private int idNumber;
    private string? empyeeType;
    private string? firstName;
    private string? lastName;
    private int phoneNumber;
    private string? emailAddress;
    private string? mailingAddress;
    private int baseSalary;

    public PorsonModel(int idNumber, string? empyeeType, string? firstName, string? lastName, int phoneNumber, string? emailAddress, string? mailingAddress, int baseSalary)
    {
        this.idNumber = idNumber;
        this.empyeeType = empyeeType;
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.emailAddress = emailAddress;
        this.mailingAddress = mailingAddress;
        this.baseSalary = baseSalary;
    }
}