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

namespace _57BlocksMusicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly IUserAplicationService userService;

        public UserController(ILogger<UserController> logger, IUserAplicationService userService)
        {
            this.logger = logger;
            this.userService = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var allUsers = await userService.GetAll();

            return Ok(allUsers);
        }

        public async Task<IActionResult> GetByEmail(string email)
        {
            var user = await userService.GetByEmail(email);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel user)
        {
            var userEntity = user.Adapt<User>();
            var createdUser = await userService.Create(userEntity);

            return Ok(createdUser);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserViewModel user)
        {
            var userEntity = user.Adapt<User>();
            var updatedUser = await userService.Update(userEntity);

            return Ok(updatedUser);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete(string userId)
        {
            var deletedUser = await userService.Delete(userId);

            return NoContent();
        }
    }
}
