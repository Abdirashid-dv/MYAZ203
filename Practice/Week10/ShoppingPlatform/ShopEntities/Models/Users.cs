namespace ShopEntities.Models;

public class Users
{
    public int Id { get; set; }
    public string Email { get; set; } = String.Empty;
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string FullName => string.Concat(FirstName + " " + LastName.ToUpper());
    public DateTime CreatedDate { get; set; }
}