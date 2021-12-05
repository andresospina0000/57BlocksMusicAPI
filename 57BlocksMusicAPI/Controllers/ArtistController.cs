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
    public class ArtistController : ControllerBase
    {
        private readonly ILogger<ArtistController> logger;
        private readonly IArtistAplicationService service;
        private readonly IUserAplicationService userService;

        public ArtistController(ILogger<ArtistController> _logger, IArtistAplicationService _service
            , IUserAplicationService _userService)
        {
            this.logger = _logger;
            this.service = _service;
            this.userService = _userService;
        }

        // GET: api/<ArtistController>
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

        // GET api/<ArtistController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArtistController>
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
