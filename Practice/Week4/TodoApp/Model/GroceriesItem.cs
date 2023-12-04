namespace TodoApp.Models;

public class GroceriesItem : TodoItem
{
    public int Quentity { get; set; }

    // Constructor
    public GroceriesItem(int Quentity)
    {
        this.Quentity = Quentity;
    }
    public override string ToString()
    {
        return $"{base.ToString()} {Quentity}";
    }

}