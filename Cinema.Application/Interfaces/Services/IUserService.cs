using Cinema.Common.Auth;
using Cinema.Common.Request;

namespace Cinema.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<string> Login(AuthUser authUser);
        Task<UserRequest> Get(string email);
        Task<Guid> Create(AuthUser authUser);
    }
}
