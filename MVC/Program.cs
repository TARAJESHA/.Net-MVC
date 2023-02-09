using MVC;
using MVC.Controllers;
using System.Net.Mail;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

PorsonControllers porsonControllers= new PorsonControllers();

while (true)
{
    Console.WriteLine("Add new employee? enter 1 or else enter 0 :");
    int data1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("xsvxgsv");
    if (data1 == 1)
    {
        Console.WriteLine("add new employee: ");

        Console.WriteLine("Enter ID number: ");

        int IdNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter employee type? full or cont : ");
        string empyeeType = Console.ReadLine();

        Console.WriteLine("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name : ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter phone number: ");
        int phoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter email address : ");
        string emailAddress = Console.ReadLine();

        Console.WriteLine("Enter mailingAddress");
        string mailingAddress = Console.ReadLine();

        Console.WriteLine("Enter base salary: ");
        int baseSalary = Convert.ToInt32(Console.ReadLine());

    PersonModel1 personModel1 = new PersonModel1(IdNumber, empyeeType, firstName, lastName, phoneNumber, emailAddress, mailingAddress, baseSalary);



        porsonControllers.Create(personModel1);
    Console.WriteLine("Employee net salary is " + porsonControllers.Details(1));



}
    else if (data1 == 0)
    {
        Console.WriteLine("Enter employee ID : ");
        int data = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Employee net salary is " + porsonControllers.Details(data));

    }
    else
    {
        Console.WriteLine("Given input is invalid, plaese try again!");
    }
    }




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
