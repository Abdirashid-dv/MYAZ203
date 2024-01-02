using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class AuthorRepository
{
    public RepositoryContext _context;

    public AuthorRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Authors AuthorInfo(int id)
    {
        var author = _context.Authors
        .Include(b => b.Books)
        .SingleOrDefault(a => a.id == id);


        if (author is null)
            throw new Exception("Author not found");

        return author;
    }

    public void AddAuthor(Authors author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
    }
}