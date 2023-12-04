namespace LibraryApp.Models;


public class Authors
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get => FirstName + " " + LastName; }

    public override string ToString()
    {
        return $"{Id,-10}{FullName}";
    }
}