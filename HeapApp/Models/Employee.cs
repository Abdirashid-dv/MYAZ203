
namespace HeapApp.Models;

public class Employee
{
    public Employee(string fullName, double salary)
    {
        FullName = fullName;
        Salary = salary;
    }

    public string FullName { get; set; }

    public double Salary { get; set; }

}