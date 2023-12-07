using ShopEntities.Models;

namespace ShopRepositories.Repositories;

public class UsersRepository : IRepository<Users>
{
    private List<Users> users;

    public UsersRepository(List<Users> users)
    {
        this.users = users;
    }

    public void Delete()
    {
        users.Clear();
    }

    public void DeleteOne(int id)
    {
        var user = GetOne(id);

        if (user != null)
            users.Remove(user);
    }

    public List<Users> GetAll()
    {
        return users;
    }

    public Users GetOne(int id)
    {
        var user = users.SingleOrDefault(usr => usr.Id.Equals(id));

        return user ?? throw new InvalidOperationException($"No user found with Id: {id}");
    }

    public void Post(Users item)
    {
        if (item == null)
            return;

        users.Add(item);
    }

    public void Update(int id, Users item)
    {
        var user = GetOne(id);

        if (item == null || user == null)
            return;

        user.Email = item.Email;
        user.FirstName = item.FirstName;
        user.LastName = item.LastName;
        user.CreatedDate = item.CreatedDate;
    }
}