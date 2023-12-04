namespace TodoApp.Models;

class UrgetItem : ImportantItem
{
    public bool IsUrgent { get; set; }

    // Constructor
    public UrgetItem(int level)
    : base(level)
    {

    }
    public UrgetItem(bool IsUrgent, int level)
    : base(level)
    {
        this.IsUrgent = IsUrgent;
    }
}