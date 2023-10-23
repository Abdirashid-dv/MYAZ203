using EmployeeApp.Models;

Employee Emp1 = new Employee();
Emp1.Id = 1;
Emp1.FirstName = "Ahmed";
Emp1.LastName = "Ali";
Console.WriteLine(Emp1);

// Employee
Employee emp2 = new Employee(2, "Bahar", "Erol");
Console.WriteLine(emp2);

// Worker
Worker worker1 = new Worker(1, "Abdirashid", "Osman");
worker1.Work();
System.Console.WriteLine(worker1);


// Manager
Manager manager1 = new Manager(101, "Abduvahap", "Oumarou", "Boss");
manager1.Work();
System.Console.WriteLine(manager1);

// Assistance
Assistance Ass1 = new Assistance()
{
    Id = 120,
    FirstName = "Mashour",
    LastName = "Kan",
    Position = "Manager Assistance"
};
Ass1.Work();
System.Console.WriteLine(Ass1);

// Student
Student student1 = new Student(2, "Hamza", "Khan");
student1.Work();
student1.doIntern();
System.Console.WriteLine(student1);