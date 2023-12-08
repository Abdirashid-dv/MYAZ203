using Microsoft.AspNetCore.Mvc;
using ShopEntities.Models;
using ShopRepositories.Repositories;

namespace ShopApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
    private ProductsRepository repository;

    public ProductsController(ProductsRepository repository)
    {
        this.repository = repository;
    }

    [HttpPost]
    public void Post(Products item)
    {
        repository.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Products item)
    {
        repository.Update(id, item);
    }

    [HttpGet]
    public List<Products> GetAll()
    {
        return repository.GetAll();
    }

    [HttpGet("{id:int}")]
    public Products GetOne(int id)
    {
        return repository.GetOne(id);
    }

    [HttpDelete]
    public void Delete()
    {
        repository.Delete();
    }

    [HttpDelete("{id:int}")]
    public void DeleteOne(int id)
    {
        repository.DeleteOne(id);
    }

}