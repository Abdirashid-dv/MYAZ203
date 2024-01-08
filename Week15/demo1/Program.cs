using Microsoft.EntityFrameworkCore;
using Model;
using Repository;

var phone = Phone.CreatePhone().SetModel("iPhone 15 Pro Max").SetSize(6.7).SetPrice(2199).SetColor("Black");
phone.Company = new Company() { Name = "Apple", Country = "USA" };

var context = new RepositoryContext();
context.Phones.Add(phone);
context.SaveChanges();

GetAllCompanies(); // Get all companies
GetAllPhones(); // Get all phones
GetAllPhonesWithCompany(); // Get all phones with company

static void GetAllCompanies()
{
    var context = new RepositoryContext();

    var companies = context.Companies.ToList();

    foreach (var company in companies)
    {
        Console.WriteLine(company);
    }

    Console.ReadKey();
}

static void GetAllPhones()
{
    var context = new RepositoryContext();

    context.Phones.ToList()
    .ForEach(phone => Console.WriteLine(phone));

    Console.ReadLine();

}

static void GetAllPhonesWithCompany()
{
    var context = new RepositoryContext();

    var phones = context.Phones.Include(p => p.Company).ToList();

    foreach (var phone in phones)
    {
        Console.WriteLine(phone);
    }

    Console.ReadLine();

}