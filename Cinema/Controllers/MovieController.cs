using Cinema.Application.Interfaces;
using Cinema.Common.DTOs;
using Cinema.Common.Request;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MovieResponse>>> GetAll()
        {
            var movies = await _movieService.GetAll();

            return Ok(movies);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] MovieRequest movieRequest)
        {
            var movie = await _movieService.Create(movieRequest);

            return Ok(movie);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> Update(Guid id, [FromBody] MovieRequest movieRequest)
        {
            var movie = await _movieService.Update(id, movieRequest);

            return Ok(id);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> Delete(Guid id)
        {
            _movieService.Delete(id);

            return Ok();
        }
    }
}
