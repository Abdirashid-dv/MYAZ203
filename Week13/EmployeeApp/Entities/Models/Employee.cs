namespace Entities.Models;

public class Employee
{
    // Auto-implemented properties
    public int Id { get; set; }
    public string? FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}