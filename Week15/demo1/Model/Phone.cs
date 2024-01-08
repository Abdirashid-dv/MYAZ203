namespace Model;

public class Phone
{
    public Phone()
    {

    }
    public int Id { get; set; }
    public string? Model { get; set; }
    public double Size { get; set; }
    public decimal Price { get; set; }
    public string? Color { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }

    public Phone SetModel(string model)
    {
        Model = model;
        return this;
    }

    public Phone SetSize(double size)
    {
        Size = size;
        return this;
    }


    public Phone SetPrice(decimal price)
    {
        Price = price;
        return this;
    }

    public Phone SetId(int id)
    {
        Id = id;
        return this;
    }
    public Phone SetColor(string color)
    {
        Color = color;
        return this;
    }

    public static Phone CreatePhone() => new Phone();


    public override string ToString()
    {
        return $"Id: {Id}, Model: {Model}, Size: {Size}, Price: {Price}, Color: {Color}, Company: {Company}";
    }


}