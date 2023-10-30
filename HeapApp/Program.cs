
using HeapApp.Models;

Heap heap1 = new MaxHeap();

List<Employee> employees = new List<Employee>(){
     new Employee("Elma Othman", 4500),
     new Employee ("Abduvahap Oumarou", 2500),
     new Employee("John Smith", 6000),
     new Employee("Emily Davis", 3800),
     new Employee("Michael Johnson", 5200),
     new Employee("Sarah Brown", 3000)
 };
foreach (var employee in employees)
{
    heap1.Insert(employee);
}

System.Console.WriteLine(heap1.Extract() + " " + heap1.count);
System.Console.WriteLine(heap1.Extract() + " " + heap1.count);


/**  -- This Example Of While We are Using Int List
NewMethod(heap1);

static void NewMethod(Heap heap1)
{
    var list = new List<int>() { 23, 44, 06, 34, 35, 61, 19 };

    foreach (var item in list)
    {
        heap1.Insert(item);
    }

    int i = 0;

    do
    {
        System.Console.WriteLine(heap1.count);
        i += 1;

    } while (i < list.Count);
}
**/
