using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        //fluent API
        builder.HasKey(e => e.Id); // Id, EmployeeId -> Core PK

        builder.Property(e => e.FirstName).IsRequired();

        builder.Property(e => e.LastName).IsRequired();

        builder.HasData(
            new Employee() { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Salary = 75000, CompanyId = 1 },
            new Employee() { Id = 2, FirstName = "Ayşe", LastName = "Demir", Salary = 80000, CompanyId = 1 },
            new Employee() { Id = 3, FirstName = "Mehmet", LastName = "Kaya", Salary = 50000, CompanyId = 2 },
            new Employee() { Id = 4, FirstName = "Zeynep", LastName = "Yılmaz", Salary = 100000, CompanyId = 2 },
            new Employee() { Id = 5, FirstName = "Ali", LastName = "Demir", Salary = 1200000, CompanyId = 3 }
        );
    }

}