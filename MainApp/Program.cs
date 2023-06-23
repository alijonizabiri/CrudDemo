using Domain.Models;
using Infrastructure.Services;
var empService = new EmployeeService();
for (int i = 1; i <= 1; i++)
{
    System.Console.WriteLine($"Employee {i}");
    var emp = new Employee();
    System.Console.Write("Enter your name : ");
    emp.FirstName = Console.ReadLine();
    System.Console.Write("Enter your surname : ");
    emp.LastName = Console.ReadLine();
    System.Console.Write("Enter your salary : ");
    emp.Salary = Convert.ToDecimal(Console.ReadLine());
    System.Console.Write("Enter your birthDate : ");
    emp.BirthDate = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) );
    System.Console.Write("Enter your department name : ");
    emp.Department = new Department();
    emp.Department.Name = Console.ReadLine();
    System.Console.Write("Enter your department name : ");
    emp.Department.Description = Console.ReadLine();

    empService.AddEmployee(emp);
}


System.Console.WriteLine("Name           Surname           Salary           BirthDate           Department name");
foreach (var e in empService.GetEmployees())
{
    System.Console.WriteLine($"{e.FirstName}           {e.LastName}           {e.Salary}           {e.BirthDate}           {e.Department.Name}");
}