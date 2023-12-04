namespace TodoApp.Models;

class ImportantItem : TodoItem
{
    public string Priority { get; private set; } = "Atanmadı";

    // Constructor
    public ImportantItem(int level)
    {
        PriorityLevel(level);
    }
    public void PriorityLevel(int level)
    {
        switch (level)
        {
            case 0:
                Priority = "Az Önemli";
                break;
            case 1:
                Priority = "Önemli";
                break;
            case 2:
                Priority = "Çok Önemli";
                break;
            default:
                Priority = "Atanmadı";
                break;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Priority.PadLeft(10)}";
    }

}