using AutoMapper;
using Cinema.Application.Interfaces;
using Cinema.Common.DTOs;
using Cinema.Common.Request;
using Cinema.DAL.Interfaces;
using Cinema.Domain.Models;

namespace Cinema.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<Movie> Get(Guid id)
        {
            return await _movieRepository.Get(id);
        }

        public async Task<List<MovieResponse>> GetAll()
        {
            var movieEntities = await _movieRepository.GetAll();

            return _mapper.Map<List<MovieResponse>>(movieEntities);
        }

        public async Task<Guid> Create(MovieRequest movieRequest)
        {
            var movie = _mapper.Map<Movie>(movieRequest);

            return await _movieRepository.Create(movie);
        }

        public async Task<Guid> Update(Guid id, MovieRequest movieRequest)
        {
            var movie = _mapper.Map<Movie>(movieRequest);

            return await _movieRepository.Update(id, movie);
        }

        public async void Delete(Guid id)
        {
            _movieRepository.Delete(id);
        }
    }
}
