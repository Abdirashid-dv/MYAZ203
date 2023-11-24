using System.Globalization;
namespace MusicApp.Models;

public class Song : IFormattable, IComparable
{
    #region Properts
    // Properts
    public int Id { get; set; }
    public string Title { get; set; }
    public Artists? Artist { get; set; }
    public Albums? Album { get; set; }
    public string Genre { get; set; }
    public float Duration { get; set; }
    #endregion
    public int CompareTo(object? obj)
    {
        if (obj == null)
            return 1;

        if (obj is Song otherSong)
            return this.Title.CompareTo(otherSong.Title);
        else
            throw new ArgumentException("Obj has not Title");
    }

    public string ToString(string? format = "id", IFormatProvider? formatProvider = null)
    {
        if (String.IsNullOrEmpty(format)) format = "id";
        if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

        switch (format.ToLowerInvariant())
        {
            case "id":
                return $"{Id} {Title} {Duration}";
            case "title":
                return $"{Title} {Id}  {Duration}";
            case "duration":
                return $"{Duration} {Title} {Id}";
            default:
                throw new FormatException(String.Format("The {0} format string is not supported.", format));
        }
    }


    // Constructor
    public Song()
    {
        Title = string.Empty;
        Genre = string.Empty;

    }
    public Song(int id, string title, Artists artist, Albums album, string genre, float duration)
    {
        Id = id;
        Title = title;
        Artist = artist;
        Album = album;
        Genre = genre;
        Duration = duration;
    }
}
