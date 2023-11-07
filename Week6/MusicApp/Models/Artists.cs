namespace MusicApp.Models;

public class Artists
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Genre { get; set; }

    // Constructor
    public Artists()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Genre = string.Empty;
    }

    public Artists(int id, string firstName, string lastName, string genre)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Genre = genre;
    }
}