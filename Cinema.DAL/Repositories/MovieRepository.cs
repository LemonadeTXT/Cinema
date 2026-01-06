using AutoMapper;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces;
using Cinema.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;

        public MovieRepository(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<Movie> Get(Guid id)
        {
            var movieEntity = await _applicationContext.Movies.FirstOrDefaultAsync(m => m.Id == id);

            return _mapper.Map<Movie>(movieEntity);
        }

        public async Task<List<Movie>> GetAll()
        {
            var movieEntities = await _applicationContext.Movies.AsNoTracking().ToListAsync();

            return _mapper.Map<List<Movie>>(movieEntities);
        }

        public async Task<Guid> Create(Movie movie)
        {
            var movieEntity = _mapper.Map<MovieEntity>(movie);

            await _applicationContext.Movies.AddAsync(movieEntity);
            await _applicationContext.SaveChangesAsync();

            return movieEntity.Id;
        }

        public async Task<Guid> Update(Guid id, Movie movie)
        {
            await _applicationContext.Movies
                .Where(m => m.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(m => m.Title, movie.Title)
                    .SetProperty(m => m.Description, movie.Description)
                    .SetProperty(m => m.AgeRating, movie.AgeRating)
                    .SetProperty(m => m.FreeSeats, movie.FreeSeats)
                    .SetProperty(m => m.Session, movie.Session));

            return movie.Id;
        }

        public async void Delete(Guid id)
        {
            await _applicationContext.Movies
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();
        }
    }
}
