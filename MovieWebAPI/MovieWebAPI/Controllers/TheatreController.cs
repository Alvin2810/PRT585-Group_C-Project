using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreWebAPI.Models.Theatre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreWebAPI.Controllers
{
    [EnableCors("angular")]
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {
        private ITheatre_Service _Theatre_Service;

        public TheatreController(ITheatre_Service Theatre_Service)
        {
            _Theatre_Service = Theatre_Service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddTheatre(String name)
        {
            var result = await _Theatre_Service.AddTheatre(name);
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
        public async Task<IActionResult> GetAllTheatres()
        {
            var result = await _Theatre_Service.GetAllTheatres();
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
        public async Task<IActionResult> GetTheatreById(long id)
        {
            var result = await _Theatre_Service.GetTheatreById(id);
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
        public async Task<IActionResult> UpdateTheatre(long Theatre_id, string name)
        {
            var result = await _Theatre_Service.UpdateTheatre(Theatre_id, name);
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
        public async Task<IActionResult> DeleteTheatre(long Theatre_id)
        {
            var result = await _Theatre_Service.DeleteTheatre(Theatre_id);
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