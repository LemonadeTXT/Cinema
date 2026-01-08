using Cinema.Common.Request;
using Cinema.Common.Response;

namespace Cinema.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserRequest> Get(string email);
        Task<Guid> Create(UserResponse userResponse);
    }
}
