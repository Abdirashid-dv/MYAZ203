namespace ShopRepositories.Repositories;

public interface IRepository<T>
{
    List<T> GetAll();
    T GetOne(int id);
    void Post(T item);
    void Update(int id, T item);
    void Delete();
    void DeleteOne(int id);
}