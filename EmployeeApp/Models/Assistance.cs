namespace EmployeeApp.Models
{
    public class Assistance : Manager
    {
        public Assistance()
        {
        }

        public Assistance(int id, string Fname, string Lname, string Position)
         : base(id, Fname, Lname, Position)
        {
        }

        public void MakeReport()
        {
            System.Console.WriteLine("Report is prepared....");
        }


        public override void Work()
        {
            System.Console.WriteLine("Assistance is working...");
        }
    }
}