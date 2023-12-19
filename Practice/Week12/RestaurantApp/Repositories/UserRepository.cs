using Entities.Models;
using Repositories.Contracts;
using Repositories.Services;

namespace Repositories;

public class UserRepository : IRepository<User>
{
    private List<User> _users;

    public UserRepository(List<User> users)
    {
        _users = users;
    }
    public User GetOne(int id)
    {
        var user = _users.SingleOrDefault(user => user.Id == id) ?? throw new Exception("User not found");
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

        if (user == null)
        {
            throw new Exception("User not found");
        }

        _users.Remove(user);
    }

    public User GetData(string email, string password)
    {
        var user = _users.SingleOrDefault(user => user.Email == email);

        if (user == null)
        {
            throw new Exception("User not found");
        }

        // Verify password
        if (!user.Password.Equals(password.Encoder(user.Salt)))
        {
            throw new Exception("Invalid password");
        }
        return user;
    }


}