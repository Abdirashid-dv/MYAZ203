namespace Entities.Models;


public class Authors
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public ICollection<Books> Books { get; set; }
}