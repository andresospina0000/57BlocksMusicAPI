using _57Blocks.Music.BLogic.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _57BlocksMusicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserAplicationService userService;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
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
            var userEntity = new UserViewModel().ToEntity(user);
            var createdUser = await userService.Create(userEntity);

            return Ok(createdUser);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserViewModel user)
        {
            var userEntity = new UserViewModel().ToEntity(user);
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
