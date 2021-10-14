﻿using LOGIC.Services.Interfaces;
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

        [HttpPost]
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

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateMovie(Movie_Pass_Object Movie)
        {
            var result = await _Movie_Service.UpdateMovie(Movie.movie_id, Movie.name, Movie.releaseDate,Movie.language);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> DeleteMovie(Movie_Pass_Object Movie)
        {
            var result = await _Movie_Service.DeleteMovie(Movie.movie_id);
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