using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace RestaurantApi.Controllers;

[ApiController]
[Route("Item")]

public class ItemController : ControllerBase
{
    private readonly ItemRepository _itemRepository;

    public ItemController(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    // GET: All items
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = _itemRepository.GetAll();

        return Ok(items);
    }

    // GET: Item by id
    [HttpGet("{id}")]
    public IActionResult GetItem(int id)
    {
        var item = _itemRepository.GetOne(id);

        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    // POST: Add item
    [HttpPost]
    public IActionResult AddItem(Items item)
    {
        _itemRepository.Post(item);

        return Ok(item);
    }

    // Delete: Delete item

    [HttpDelete("{id}")]
    public IActionResult DeleteItem(int id)
    {
        var item = _itemRepository.GetOne(id);

        if (item == null)
        {
            return NotFound();
        }

        _itemRepository.Delete(id);

        return Ok(item);
    }

}