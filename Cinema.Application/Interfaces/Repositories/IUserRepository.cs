using Cinema.Domain.Models;

namespace Cinema.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> Get(string email);
        Task<Guid> Create(User user);
    }
}
