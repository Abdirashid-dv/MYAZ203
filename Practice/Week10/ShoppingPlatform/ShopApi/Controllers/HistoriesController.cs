using Microsoft.AspNetCore.Mvc;
using ShopEntities.Models;
using ShopRepositories.Repositories;

namespace ShopApi.Controllers;

[ApiController]
[Route("api/history")]

public class HistoriesController : ControllerBase
{
    private HistoriesRepository repository;

    public HistoriesController(HistoriesRepository repository)
    {
        this.repository = repository;
    }

    [HttpPost]
    public void Post(Histories item)
    {
        repository.Post(item);
    }

    [HttpPut("{id:int}")]
    public void Update(int id, Histories item)
    {
        repository.Update(id, item);
    }

    [HttpGet]
    public List<Histories> GetAll()
    {
        return repository.GetAll();
    }

    [HttpGet("{id:int}")]
    public Histories GetOne(int id)
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