using _57Blocks.Music.BLogic.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using _57Blocks.Music.DataModels;
using System.ComponentModel.DataAnnotations;

namespace _57BlocksMusicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly IUserAplicationService service;

        public UserController(ILogger<UserController> logger, IUserAplicationService userService)
        {
            this.logger = logger;
            this.service = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var allUsers = await service.GetAll();

            return Ok(allUsers);
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var user = await service.GetByEmail(email);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }

            var userEntity = user.Adapt<User>();
            var createdUser = await service.Create(userEntity);

            return Ok(createdUser);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserViewModel user)
        {
            var userEntity = user.Adapt<User>();
            var updatedUser = await service.Update(userEntity);
            var result = updatedUser.Adapt<UserViewModel>();

            return Ok(result);
        }

        //[Authorize]
        [HttpDelete("{email}")]
        public async Task<IActionResult> Delete(string email)
        {
            var deletedUser = await service.Delete(email);

            return NoContent();
        }
    }
}
