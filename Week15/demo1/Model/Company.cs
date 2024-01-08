namespace Model;

public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Id: {CompanyId}, Name: {Name}, Country: {Country}";
    }

}