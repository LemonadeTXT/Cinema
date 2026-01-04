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

        public async Task<List<Movie>> GetMovies()
        {
            var movieEntities = await _applicationContext.Movies.AsNoTracking().ToListAsync();

            return _mapper.Map<List<Movie>>(movieEntities);
        }

        public async void Create(Movie movie)
        {
            var movieEntity = _mapper.Map<MovieEntity>(movie);

            await _applicationContext.Movies.AddAsync(movieEntity);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
