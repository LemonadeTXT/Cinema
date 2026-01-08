using Cinema.Domain.Models;

namespace Cinema.Application.Interfaces.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> Get(Guid id);
        Task<List<Movie>> GetAll();
        Task<Guid> Create(Movie movie);
        Task<Guid> Update(Guid id, Movie movie);
        Task Delete(Guid id);
    }
}
