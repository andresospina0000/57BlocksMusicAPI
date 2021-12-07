using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _57BlocksMusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly ILogger<ArtistController> logger;
        private readonly IArtistAplicationService service;

        /// <summary>
        /// Implements a constructor with the dependency injection needed for the controller
        /// </summary>
        /// <param name="_logger"></param>
        /// <param name="_service"></param>
        /// <param name="_userService"></param>
        public ArtistController(ILogger<ArtistController> _logger, IArtistAplicationService _service)
        {
            this.logger = _logger;
            this.service = _service;
        }

        /// <summary>
        /// Get all the artists created by the user (email) that only this user can see
        /// </summary>
        /// <param name="email">The user email</param>
        /// <returns></returns>
        [HttpGet("private/{email}")]
        public async Task<IActionResult> GetAllPrivate(string email)
        {
            var privateArtists = await service.GetAllPrivate(email);
            return Ok(privateArtists);
        }

        /// <summary>
        /// Get all the artists that any user can fetch
        /// </summary>
        /// <param name="email">The user email</param>
        /// <returns></returns>
        [HttpGet("public/{email}")]
        public async Task<IActionResult> GetAllPublic(string email)
        {
            var privateArtists = await service.GetAllPublic(email);
            return Ok(privateArtists);
        }

        // GET api/<ArtistController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates an artist. The artist will be linked to the user email (if the user is already registered)
        /// </summary>
        /// <param name="artist">The json object with all the properties of an artist</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ArtistViewModel artist)
        {
            var artistEntity = artist.Adapt<Artist>();
            var createdArtist = await service.Create(artistEntity);
            var result = createdArtist.Adapt<ArtistViewModel>();

            return Ok(result);
        }

        // PUT api/<ArtistController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArtistController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
