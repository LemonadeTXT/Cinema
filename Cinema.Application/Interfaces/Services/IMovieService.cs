using Cinema.Common.DTOs;
using Cinema.Common.Request;
using Cinema.Domain.Models;

namespace Cinema.Application.Interfaces.Services
{
    public interface IMovieService
    {
        Task<Movie> Get(Guid id);
        Task<List<MovieResponse>> GetAll();
        Task<Guid> Create(MovieRequest movieRequest);
        Task<Guid> Update(Guid id, MovieRequest movieRequest);
        Task Delete(Guid id);
    }
}
