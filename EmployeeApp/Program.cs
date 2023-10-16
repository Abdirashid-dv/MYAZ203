Employee Emp1 = new Employee();
Emp1.Id = 1;
Emp1.FirstName = "Ahmed";
Emp1.LastName = "Ali";
Console.WriteLine(Emp1);
System.Console.WriteLine(Emp1.AtCreatedDate);

Employee emp2 = new Employee(2, "Bahar", "Erol");
Console.WriteLine(emp2);
System.Console.WriteLine(emp2.AtCreatedDate);


Employee emp3 = new Employee("Abdirashid", "Osman");
Console.WriteLine(emp3);
System.Console.WriteLine(emp3.AtCreatedDate);
