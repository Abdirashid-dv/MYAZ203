namespace MusicApp.Models;

public class Albums
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseYear { get; set; }
    public string Genre { get; set; }

    // Constructor

    public Albums()
    {
        Title = string.Empty;
        Genre = string.Empty;
    }

    public Albums(int id, string title, DateTime releaseYear, string genre)
    {
        Id = id;
        Title = title;
        ReleaseYear = releaseYear;
        Genre = genre;
    }
}
