namespace TodoApp.Models;

public class TodoList
{
    // Property
    private List<TodoItem> items;

    // Constructor
    public TodoList()
    {
        items = new List<TodoItem>();
    }

    public TodoList(List<TodoItem> todoItems)
    : this()
    {
        foreach (var item in todoItems)
        {
            items.Add(item);
        }
    }

    // Methods
    public void AddItem(TodoItem todoItem)
    {

        items.Add(todoItem);
    }

    public void RemoveItem(int id)
    {
        items.RemoveAt(id);
    }

    public void MarkComplete(int id)
    {
        var entity = items.Where(b => b.Id.Equals(id)).First();


        if (entity != null)
            entity.IsComplete = true;
        else
            System.Console.WriteLine("Not Found");
    }

    public List<TodoItem> GetDueItems(DateTime date)
    {
        var entity = items.Where(item => item.DueDate.Date < date.Date).ToList();
        return entity;

    }

    public List<TodoItem> GetItems()
    {
        return items;
    }

    public TodoItem? GetOneItem(int id)
    {
        var entity = items.Where(b => b.Id.Equals(id)).SingleOrDefault();
        return entity;
    }

    public void DisplayTask()
    {
        foreach (var item in items)
        {
            System.Console.WriteLine(item.ToString());
        }
    }

}