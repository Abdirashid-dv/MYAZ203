using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;


public class CompanyConfig : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(c => c.CompanyId);

        builder.Property(c => c.CompanyName).IsRequired();
        builder.Property(c => c.Website).IsRequired();

        builder.HasData(
            new Company() { CompanyId = 1, CompanyName = "Microsoft", Website = "https://www.microsoft.com" },
            new Company() { CompanyId = 2, CompanyName = "Apple", Website = "https://www.apple.com" },
            new Company() { CompanyId = 3, CompanyName = "Google", Website = "https://www.google.com" }
        );
    }
}