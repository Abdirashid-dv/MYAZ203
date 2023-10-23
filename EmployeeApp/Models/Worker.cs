namespace EmployeeApp.Models
{
    public class Worker : Employee
    {
        public Worker()
        {

        }

        public Worker(string Firstname, string Lastname) : base(Firstname, Lastname)
        {
        }

        public Worker(int id, string Fname, string Lname) : base(id, Fname, Lname)
        {
        }

        public override void Work()
        {
            System.Console.WriteLine("Worker is working...");
        }
    }
}