// See https://aka.ms/new-console-template for more information
using TodoApp.Models;


List<TodoItem> todoItems = new List<TodoItem>{
    new TodoItem(
        id: 1,
        title:"GYM",
        dueDate: DateTime.Now.AddDays(4),
        description:"Going to destroy my body"

    ),
    new TodoItem(
        id: 2,
        title: "Going to Pazar",
        dueDate: DateTime.Now.AddDays(4),
        description: "I Will Buy For My Self Ice Cream."),
    new TodoItem(
        id: 3,
        title: "To Swimming Pool",
        dueDate: DateTime.Now.AddDays(10),
        description: "Swimming to some friends"
    ),
    new TodoItem(
        id: 5,
        title: "Meeting Manager",
        dueDate: DateTime.Now.AddDays(6),
        description: "Meeting hire manager."
    )
};

// Instance
TodoList todoList = new TodoList(todoItems);

// Getting Items by id and  Marking
System.Console.WriteLine(todoList.GetOneItem(1));
todoList.MarkComplete(2);

System.Console.WriteLine("------------------------------------------");

// Getting Items With Due Date and Without
List<TodoItem> items = todoList.GetItems();
List<TodoItem> dueDateList = todoList.GetDueItems(DateTime.Now.AddDays(5));

foreach (var item in dueDateList)
{
    System.Console.WriteLine(item.ToString());
}
System.Console.WriteLine("------------------------------------------");
// Displaying Tasks
todoList.DisplayTask();
System.Console.WriteLine("------------------------------------------");
// Instance Urgent
UrgetItem urgetItem = new UrgetItem(true, 1);
urgetItem.Id = 6;
urgetItem.Title = "Meeting GirlFriend!";
urgetItem.DueDate = DateTime.Now.AddDays(1);
urgetItem.Description = "We will meet city plaza hotel.";
System.Console.WriteLine(urgetItem.ToString());