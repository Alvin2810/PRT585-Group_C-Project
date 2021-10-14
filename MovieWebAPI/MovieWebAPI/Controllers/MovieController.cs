using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieWebAPI.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebAPI.Controllers
{
    [EnableCors("angular")]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovie_Service _Movie_Service;

        public MovieController(IMovie_Service Movie_Service)
        {
            _Movie_Service = Movie_Service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddMovie(String name, String releaseDate, String language)
        {
            var result = await _Movie_Service.AddMovie(name,releaseDate,language);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllMovies()
        {
            var result = await _Movie_Service.GetAllMovies();
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetMovieById(long id)
        {
            var result = await _Movie_Service.GetMovieById(id);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> UpdateMovie(long movie_id,string name, string releaseDate, string language)
        {
            var result = await _Movie_Service.UpdateMovie(movie_id, name, releaseDate,language);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> DeleteMovie(long movie_id)
        {
            var result = await _Movie_Service.DeleteMovie(movie_id);
            switch (result.success)
            {
                case true: 
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

    }
}