using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
    }

    // CRUD
    // Create
    // Read
    // Update
    // Delete

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    public void AddEmployee(Employee employee)  
    {
        employee.Id = _employees.Count + 1;
        _employees.Add(employee);
    }  

    public Employee UpdateEmployee(Employee employee)
    {
        foreach (var e in _employees)
        {
            if ( e.Id == employee.Id )
            {
                e.FirstName = employee.FirstName;
                e.LastName = employee.LastName;
                e.BirthDate = employee.BirthDate;
                e.Salary = employee.Salary;
                e.Department.Name = employee.Department.Name;
                e.Department.Description = employee.Department.Description; 

                return e;
            }
        }
        return null;
    }

    public string DeleteEmployee(int id)
    {
        foreach (var e in _employees)
        {
            if (e.Id == id)
            {
                _employees.Remove(e);
                return "Employee deleted successfully";
            }
        }
        return "Employee not found";
    }
}
