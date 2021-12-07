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
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> logger;
        private readonly IAlbumAplicationService service;

        /// <summary>
        /// Implements a constructor with the dependency injection needed for the controller
        /// </summary>
        /// <param name="_logger"></param>
        /// <param name="_service"></param>
        /// <param name="_userService"></param>
        public AlbumController(ILogger<AlbumController> _logger, IAlbumAplicationService _service)
        {
            this.logger = _logger;
            this.service = _service;
        }

        // GET: api/<AlbumController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AlbumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Get all the albums created by the user (email) that only this user can see
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("private/{email}")]
        public async Task<IActionResult> GetAllPrivate(string email)
        {
            var privateArtists = await service.GetAllPrivate(email);
            return Ok(privateArtists);
        }

        /// <summary>
        /// Get all the albums that any user can fetch
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("public/{email}")]
        public async Task<IActionResult> GetAllPublic(string email)
        {
            var privateArtists = await service.GetAllPublic(email);
            return Ok(privateArtists);
        }

        /// <summary>
        /// Creates an album. The album will be linked to the user email (if the user is already registered)
        /// </summary>
        /// <param name="album">The json object with all the properties of an album</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AlbumViewModel album)
        {
            var albumEntity = album.Adapt<Album>();
            var createdAlbum = await service.Create(albumEntity);
            var result = createdAlbum.Adapt<AlbumViewModel>();

            return Ok(result);
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlbumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
