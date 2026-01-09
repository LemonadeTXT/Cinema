using Cinema.Domain.Models;

namespace Cinema.Application.Interfaces.Auth
{
    public interface IJwtProvider
    {
        string GenerateToken(User user);
    }
}
