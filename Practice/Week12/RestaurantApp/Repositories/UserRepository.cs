using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class UserRepository : IRepository<User>
{
    private List<User> _users { get; set; }

    public UserRepository()
    {
        _users = new List<User>();
    }

    public User GetOne(int id)
    {
        var user = _users.SingleOrDefault(x => x.Id == id);

        if (user == null)
        {
            throw new Exception("User not found");
        }
        return user;
    }

    public void Post(User entity)
    {
        // encode password
        entity.Password = entity.Password.Encoder(entity.Salt);
        _users.Add(entity);
    }

    public void Delete(int id)
    {
        var user = GetOne(id);

        _users.Remove(user);
    }

    public User GetData(string email, string password)
    {
        var user = _users.SingleOrDefault(x => x.Email == email && x.Password == password);

        if (user == null)
        {
            throw new Exception("User not found");
        }
        return user;
    }


}