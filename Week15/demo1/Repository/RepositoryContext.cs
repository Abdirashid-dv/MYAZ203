using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository;

public class RepositoryContext : DbContext
{
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = demo.db;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().HasData(
            new Company { CompanyId = 1, Name = "Apple", Country = "USA" },
            new Company { CompanyId = 2, Name = "Samsung", Country = "South Korea" },
            new Company { CompanyId = 3, Name = "Huawei", Country = "China" }
        );

        modelBuilder.Entity<Phone>().HasData(
            new Phone
            {
                Id = 1,
                Model = "Samsung Galaxy S10",
                Size = 4.7,
                Price = 1299,
                Color = "White",
                CompanyId = 2
            },
            new Phone
            {
                Id = 2,
                Model = "iPhone 7",
                Size = 4.7,
                Price = 1499,
                Color = "Black",
                CompanyId = 1
            },
            new Phone
            {
                Id = 3,
                Model = "P30 Pro",
                Size = 4.7,
                Price = 1699,
                Color = "White",
                CompanyId = 3
            },
            new Phone
            {
                Id = 4,
                Model = "iPhone 11 Pro Max",
                Size = 5.8,
                Price = 1999,
                Color = "Black",
                CompanyId = 1
            }
        );

        base.OnModelCreating(modelBuilder);
    }
}