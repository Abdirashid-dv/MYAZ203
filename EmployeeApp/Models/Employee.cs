using System.Dynamic;
namespace EmployeeApp.Models;
public class Employee
{

    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public DateTime AtCreatedDate { get; private set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName.ToUpper();
        }
    }

    public virtual void Work()
    {
        System.Console.WriteLine("Employee is working...");
    }

    // Asiriyukleme -- Overload
    // Constructor Geriye donus tipi yoktur
    public Employee()
    {
        System.Console.WriteLine("An instance has been derived from Employee");
        AtCreatedDate = DateTime.Now;
    }

    // this will use it returned the upper constructor
    public Employee(int id, string Fname, string Lname) : this(Fname, Lname)
    {
        Id = id;

    }

    public Employee(string Firstname, string Lastname) : this()
    {

        this.FirstName = Firstname;
        this.LastName = Lastname;
    }

    public override string ToString()
    {
        return $"[{Id}] {FullName} {this.AtCreatedDate}";
    }


}
