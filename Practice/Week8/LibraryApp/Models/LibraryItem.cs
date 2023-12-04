
namespace LibraryApp.Models;

public class LibraryItem : IBooks
{
    public LibraryItem(int id, string title, Authors author, DateTime publishYear, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
        IsAvailable = isAvailable;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public Authors Author { get; set; }
    public DateTime PublishYear { get; set; }
    public bool IsAvailable { get; set; }

    public void Borrow()
    {
        if (IsAvailable.Equals(false))
        {
            System.Console.WriteLine($"{Title} is not available");
        }
        else
        {
            SetAvailability(false);
        }

    }

    public int CompareTo(LibraryItem? other)
    {
        if (other is LibraryItem libraryItem)
        {
            return PublishYear.CompareTo(libraryItem.PublishYear);
        }
        else
        {
            throw new Exception("Check Your Parameter");
        }
    }

    public override string ToString()
    {
        return String.Format("{0} {1} {2} {3} {4}",
        Id, Title, Author.ToString(), PublishYear, IsAvailable);
    }

    public void Return()
    {
        SetAvailability(true);
    }

    public void SetAvailability(bool available)
    {
        IsAvailable = available;
    }
}