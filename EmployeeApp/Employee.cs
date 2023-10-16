using System.Dynamic;

class Employee
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
        // FirstName = Fname;
        // LastName = Lname;

    }

    public Employee(string Firstname, string Lastname) : this()
    {
        // Random id = new Random();
        // id.Next(1, 100);
        this.FirstName = Firstname;
        this.LastName = Lastname;
    }

}