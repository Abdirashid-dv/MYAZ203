namespace EmployeeApp.Models
{
    public class Manager : Employee
    {
        public string? Position { get; set; }

        public void GetHire()
        {
            System.Console.WriteLine("Get Hired...");
        }
        public Manager()
        {
        }

        public Manager(int id, string Fname, string Lname, string Position) : base(id, Fname, Lname)
        {
            this.Position = Position;
        }
    }
}