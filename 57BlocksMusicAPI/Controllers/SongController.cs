using _57Blocks.Music.BLogic.AplicationServices;
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
    public class SongController : ControllerBase
    {
        private readonly ILogger<SongController> logger;
        private readonly ISongAplicationService service;
        private readonly IUserAplicationService userService;

        public SongController(ILogger<SongController> _logger, ISongAplicationService _service
            , IUserAplicationService _userService)
        {
            this.logger = _logger;
            this.service = _service;
            this.userService = _userService;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public string GetSongsByAlbum(string albumId)
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

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SongsController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SongViewModel song)
        {
            var songEntity = song.Adapt<Song>();
            var createdAlbum = await service.Create(songEntity);
            var result = createdAlbum.Adapt<SongViewModel>();

            return Ok(result);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
