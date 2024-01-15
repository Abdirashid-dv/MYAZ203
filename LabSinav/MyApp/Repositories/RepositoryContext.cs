using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace Repositories;

public class RepositoryContext : DbContext
{

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=School.db");
    }
}