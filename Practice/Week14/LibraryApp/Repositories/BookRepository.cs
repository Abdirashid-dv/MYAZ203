using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;


public class BookRepository
{
    public RepositoryContext _context;

    public BookRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Books BookInfo(int id)
    {
        var Book = _context.Books
        .Include(a => a.Authors)
        .SingleOrDefault(b => b.id == id);

        if (Book is null)
            throw new Exception("Book not found");

        return Book;
    }

    public void AddBook(Books book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Borrow(int id)
    {
        var Book = BookInfo(id);

        if (Book.Quantity <= 0)
            throw new Exception($"The Book {Book.Title} is not available");

        Book.Quantity -= 1;

        _context.SaveChanges();
    }

    public void Return(int id)
    {
        var Book = BookInfo(id);

        Book.Quantity += 1;

        _context.SaveChanges();
    }

}