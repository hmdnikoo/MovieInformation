using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieInformation.API.Models;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.Domain;

namespace MovieInformation.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieController(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MovieItem movieItem)
        {
            var movie = new Movie(movieItem.Title,movieItem.StoryLine, movieItem.Language);
            await _movieRepository.AddAsync(movie);

            return Created(String.Empty, movie.Id);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromBody] MovieItem movieItem)
        {
            var movie = await _movieRepository.GetByIdAsync(movieItem.Id);
            movie.Update(movieItem.Title, movieItem.StoryLine, movieItem.Language);
            _movieRepository.Update(movie);

             return Ok();
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetMovie(Guid id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if(movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpDelete("{id:Guid}", Name = nameof(DeleteMovie))]
        public async Task<IActionResult> DeleteMovie(Guid id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            _movieRepository.Delete(movie);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _movieRepository.GetAll();
            if (movies.Count == 0)
            {
                return NotFound();
            }

            return Ok(movies);
        }
    }
}
