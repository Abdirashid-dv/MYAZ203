using Microsoft.AspNetCore.Mvc;
using ShopEntities.Models;
using ShopRepositories.Repositories;

namespace ShopApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsersController : ControllerBase
{
    private UsersRepository repository;

    public UsersController(UsersRepository repository)
    {
        this.repository = repository;
    }

    [HttpPost]
    public void Post(Users item)
    {
        repository.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Users item)
    {
        repository.Update(id, item);
    }

    [HttpGet]
    public List<Users> GetAll()
    {
        return repository.GetAll();
    }

    [HttpGet("{id:int}")]
    public Users GetOne(int id)
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