namespace EmployeeApp.Models
{
    public class Student : Employee
    {
        public bool IsPartTime { get; set; }
        public Student()
        {

        }

        public Student(int id, string Fname, string Lname) : base(id, Fname, Lname)
        {

        }


        public void doIntern()
        {
            System.Console.WriteLine("Doing Intern....");
        }

        public override void Work()
        {
            System.Console.WriteLine("Student is working...");
        }
    }
}