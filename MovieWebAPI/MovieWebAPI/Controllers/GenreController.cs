using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebAPI.Controllers
{
    [EnableCors("angular")]
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private IGenre_Service _Genre_Service;

        public GenreController(IGenre_Service Genre_Service)
        {
            _Genre_Service = Genre_Service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddGenre(String name)
        {
            var result = await _Genre_Service.AddGenre(name);
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
        public async Task<IActionResult> GetAllGenres()
        {
            var result = await _Genre_Service.GetAllGenres();
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
        public async Task<IActionResult> GetGenreById(long id)
        {
            var result = await _Genre_Service.GetGenreById(id);
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
        public async Task<IActionResult> UpdateGenre(long genre_id,string name)
        {
            var result = await _Genre_Service.UpdateGenre(genre_id, name);
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
        public async Task<IActionResult> DeleteGenre(long genre_id)
        {
            var result = await _Genre_Service.DeleteGenre(genre_id);
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