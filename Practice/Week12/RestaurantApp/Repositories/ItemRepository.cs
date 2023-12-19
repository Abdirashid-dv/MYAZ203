using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class ItemRepository : IRepository<Items>
{
    private List<Items> _items;

    public ItemRepository(List<Items> items)
    {
        _items = items;
    }

    public Items GetOne(int id)
    {
        var item = _items.SingleOrDefault(x => x.Id == id);

        if (item == null)
        {
            throw new Exception("Item not found");
        }
        return item;
    }

    public void Post(Items entity)
    {
        _items.Add(entity);
    }

    public void Delete(int id)
    {
        var item = GetOne(id);

        if (item == null)
        {
            throw new Exception("Item not found");
        }

        _items.Remove(item);
    }

    public List<Items> GetAll()
    {
        return _items;
    }

}