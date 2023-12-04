using System.Globalization;
using MusicApp.Models;

Song song1 = new Song()
{
    Id = 1,
    Title = "Shape of You",
    Artist = new Artists
    {
        Id = 101,
        FirstName = "Ed",
        LastName = "Sheeran",
        Genre = "Pop"
    },
    Album = new Albums
    {
        Id = 11001,
        Title = "÷ (Divide)",
        ReleaseYear = new DateTime(2017, 3, 3),
        Genre = "Pop"
    },
    Genre = "Pop",
    Duration = 3.53f
};

Song song2 = new Song()
{
    Id = 2,
    Title = "Billie Jean",
    Artist = new Artists
    {
        Id = 102,
        FirstName = "Michael",
        LastName = "Jackson",
        Genre = "Pop"
    },
    Album = new Albums
    {
        Id = 11002,
        Title = "Thriller",
        ReleaseYear = new DateTime(1982, 11, 30),
        Genre = "Pop"
    },
    Genre = "Pop",
    Duration = 4.54f
};
Song song3 = new Song()
{
    Id = 3,
    Title = "Bohemian Rhapsody",
    Artist = new Artists
    {
        Id = 103,
        FirstName = "Freddie",
        LastName = "Mercury",
        Genre = "Rock"
    },
    Album = new Albums
    {
        Id = 11003,
        Title = "A Night at the Opera",
        ReleaseYear = new DateTime(1975, 11, 21),
        Genre = "Rock"
    },
    Genre = "Rock",
    Duration = 5.55f
};

Song song4 = new Song()
{
    Id = 4,
    Title = "Hotel California",
    Artist = new Artists
    {
        Id = 104,
        FirstName = "Eagles",
        LastName = "",
        Genre = "Rock"
    },
    Album = new Albums
    {
        Id = 11004,
        Title = "Hotel California",
        ReleaseYear = new DateTime(1976, 12, 8),
        Genre = "Rock"
    },
    Genre = "Rock",
    Duration = 6.30f
};

Song song5 = new Song()
{
    Id = 5,
    Title = "Despacito",
    Artist = new Artists
    {
        Id = 105,
        FirstName = "Luis Fonsi & Daddy Yankee",
        LastName = "",
        Genre = "Latin Pop"
    },
    Album = new Albums
    {
        Id = 11005,
        Title = "Vida",
        ReleaseYear = new DateTime(2019, 2, 23),
        Genre = "Latin Pop"
    },
    Genre = "Latin Pop",
    Duration = 4.41f
};


// List
List<Song> songs = new List<Song>()
{
    song1, song2,song3,song4,song5
};

MusicList musicList = new MusicList(songs);

foreach (var item in musicList.Sort())
{
    System.Console.WriteLine(item.ToString("TITLE"));
}

musicList.Remove(5);
System.Console.WriteLine(new string('-', 5));
// musicList.Update(2, song4);
musicList.Display();


