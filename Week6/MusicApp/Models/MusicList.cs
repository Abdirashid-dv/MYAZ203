using System.Collections;
namespace MusicApp.Models;

public class MusicList : IEnumerable
{
    private List<Song> MusicItems { get; set; } = new List<Song>();

    // Constructor
    public MusicList()
    {
    }

    public MusicList(List<Song> musiclist)
    {
        foreach (var song in musiclist)
        {
            if (song is null)
            {
                throw new ArgumentNullException(nameof(song));
            }
            else
            {
                Add(song);
            }
        }
    }

    // Methods
    public void Add(Song song)
    {
        MusicItems.Add(song);
    }

    public Song Remove(int id)
    {
        var result = MusicItems.Where(b => b.Id.Equals(id)).FirstOrDefault();

        if (result != null)
        {
            MusicItems.Remove(result);
            return result;
        }
        else
        {
            throw new ArgumentNullException(nameof(id));
        }

    }

    public void Update(int id, Song song)
    {
        var result = MusicItems.Where(songId => songId.Id.Equals(id)).FirstOrDefault();

        if (result is null)
            throw new Exception($"The id: {id} is not exist");

        result.Title = song.Title;
        result.Artist = song.Artist;
        result.Genre = song.Genre;
        result.Album = song.Album;
        result.Duration = song.Duration;

    }

    public List<Song> Sort() //List<Song>
    {
        // ((song1, song2) => song1.Duration.CompareTo(song2.Duration))
        MusicItems.Sort();
        return MusicItems;
    }

    public void Display()
    {
        foreach (var song in MusicItems)
        {
            System.Console.WriteLine(song.ToString());
        }
    }

    public IEnumerator GetEnumerator()
    {
        return MusicItems.GetEnumerator();
    }

}