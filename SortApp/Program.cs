using SortApp.Models;

var employees = new List<Employee>();
employees.Add(new Employee()
{
    FirstName = "Ismail",
    LastName = "bülbül",
    Salary = 14000

});
employees.Add(new Employee()
{
    FirstName = "Abduvahap",
    LastName = "Omarou",
    Salary = 45_000

});
employees.Add(new Employee()
{
    FirstName = "Arlinda",
    LastName = "Uruci",
    Salary = 95000

});
System.Console.WriteLine($"Size of list:{employees.Count}");


foreach (var item in employees)
{
    System.Console.WriteLine(item);
}

employees.Sort();
System.Console.WriteLine(new String('-',5));

foreach(var number in employees)
{
	System.Console.WriteLine(number);
}

System.Console.WriteLine(new String('-',5));

var clonedEmployee = employees[0].Clone();
System.Console.WriteLine(((Employee)clonedEmployee).FirstName);
