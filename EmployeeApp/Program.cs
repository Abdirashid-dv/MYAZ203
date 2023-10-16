Employee Emp1 = new Employee();
Emp1.Id = 1;
Emp1.FirstName = "Ahmed";
Emp1.LastName = "Ali";
System.Console.WriteLine(Emp1.AtCreatedDate);

Employee emp2 = new Employee(2, "Bahar", "Erol");
System.Console.WriteLine(emp2.FullName);
System.Console.WriteLine(emp2.AtCreatedDate);


Employee emp3 = new Employee("Abdirashid", "Osman");
System.Console.WriteLine(emp3.FullName);
System.Console.WriteLine(emp3.AtCreatedDate);
