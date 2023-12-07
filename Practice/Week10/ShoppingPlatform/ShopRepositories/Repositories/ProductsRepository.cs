using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class ProductsRepository : IRepository<Products>
{
    private List<Products> products;

    public ProductsRepository(List<Products> products)
    {
        this.products = products;
    }

    public void Delete()
    {
        products.Clear();
    }

    public void DeleteOne(int id)
    {
        var prd = GetOne(id);
        if (prd != null)
            products.Remove(prd);

    }

    public List<Products> GetAll()
    {
        return products;
    }

    public Products GetOne(int id)
    {
        var product = products.SingleOrDefault(pr => pr.Id == id);

        return product ?? throw new InvalidOperationException($"No product found with Id: {id}");
    }

    public void Post(Products item)
    {
        products.Add(item);
    }

    public void Update(int id, Products item)
    {
        var prd = GetOne(id);

        if (prd == null)
            throw new Exception($"{id} is not available");

        prd.Name = item.Name;
        prd.Price = item.Price;
        prd.Quantity = item.Quantity;
    }
}