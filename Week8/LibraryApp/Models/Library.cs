using System.Collections;

namespace LibraryApp.Models;

public class Library : IEnumerable
{
    private List<LibraryItem> LibraryItems { get; set; }

    public Library()
    {
        LibraryItems = new List<LibraryItem>();
    }
    public void CreateBook(LibraryItem item)
    {
        item.SetAvailability(true);
        LibraryItems.Add(item);
    }

    public void GiveBook(int id)
    {
        var entity = LibraryItems.Where(b => b.Id.Equals(id)).FirstOrDefault();

        entity?.Borrow(); // this simplified null check
    }

    public void TakeBook(int id)
    {
        var book = LibraryItems[id];

        book?.Return();
    }

    public List<LibraryItem> GetAllBooks()
    {
        return LibraryItems;
    }

    public List<LibraryItem> GetAvailableBooks()
    {
        return LibraryItems.Where(b => b.IsAvailable.Equals(true)).ToList();
    }

    public void DeleteBook(int id)
    {
        var entity = LibraryItems.Where(b => b.Id.Equals(id)).FirstOrDefault();
        if (entity is not null)
            LibraryItems.Remove(entity);
        System.Console.WriteLine(entity?.ToString());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return LibraryItems.GetEnumerator();
    }
}