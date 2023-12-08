using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class HistoriesRepository : IRepository<Histories>
{
    private List<Histories> histories;

    public HistoriesRepository(List<Histories> histories)
    {
        this.histories = histories;
    }

    public void Delete()
    {
        histories.Clear();
    }

    public void DeleteOne(int id)
    {
        var item = GetOne(id);
        if (item != null)
            histories.Remove(item);
    }

    public List<Histories> GetAll()
    {
        return histories;
    }

    public Histories GetOne(int id)
    {
        var history = histories.SingleOrDefault(hsty => hsty.Id.Equals(id));

        return history ?? throw new InvalidOperationException($"No history found with Id: {id}"); ;
    }

    public void Post(Histories item)
    {
        if (item is null)
            return;
        histories.Add(item);
    }

    public void Update(int id, Histories item)
    {
        var history = GetOne(id);

        if (history is null)
            throw new Exception($"History with {id} is not available!");

        history.UserId = item.UserId;
        history.PurchaseDate = item.PurchaseDate;
        history.PurchaseList = item.PurchaseList;
    }
}