namespace TodoApp.Models;

public class TodoItem
{

    // Property
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplete { get; set; }

    // Constructor
    public TodoItem()
    {
        IsComplete = false;
        Title = string.Empty;
        Description = string.Empty;
    }

    public TodoItem(int id, string title, DateTime dueDate, string description)
    {
        Id = id;
        Title = title;
        DueDate = dueDate;
        Description = description;
    }

    // Methods
    public override string ToString()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        return $"{Id,-4} {status,-3} {DueDate,-20:yyyy-MM-dd HH:mm} {Title,-26} {Description}";
    }
}