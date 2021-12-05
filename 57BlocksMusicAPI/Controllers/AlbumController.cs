using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _57BlocksMusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> logger;
        private readonly IAlbumAplicationService service;
        private readonly IUserAplicationService userService;

        public AlbumController(ILogger<AlbumController> _logger, IAlbumAplicationService _service
            , IUserAplicationService _userService)
        {
            this.logger = _logger;
            this.service = _service;
            this.userService = _userService;
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

        [HttpGet("private/{email}")]
        public async Task<IActionResult> GetAllPrivate(string email)
        {
            var privateArtists = await service.GetAllPrivate(email);
            return Ok(privateArtists);
        }

        [HttpGet("public/{email}")]
        public async Task<IActionResult> GetAllPublic(string email)
        {
            var privateArtists = await service.GetAllPublic(email);
            return Ok(privateArtists);
        }

        // POST api/<AlbumController>
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
