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
        /// <summary>
        /// The aplication service that will allow all the operations that could be executed on the users data
        /// </summary>
        private readonly IUserAplicationService service;

        /// <summary>
        /// Implements a constructor with the dependency injection needed for the controller
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="userService"></param>
        public UserController(ILogger<UserController> logger, IUserAplicationService userService)
        {
            this.logger = logger;
            this.service = userService;
        }

        /// <summary>
        /// Gets all the registered users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var allUsers = await service.GetAll();

            return Ok(allUsers);
        }

        /// <summary>
        /// Gets an user by its email (if it exists)
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var user = await service.GetByEmail(email);

            return Ok(user);
        }

        /// <summary>
        /// Creates an user.
        /// </summary>
        /// <param name="user">The json object with all the properties of an user</param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the properties of an user
        /// </summary>
        /// <param name="user">The json object with all the properties of an user</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(UserViewModel user)
        {
            var userEntity = user.Adapt<User>();
            var updatedUser = await service.Update(userEntity);
            var result = updatedUser.Adapt<UserViewModel>();

            return Ok(result);
        }

        /// <summary>
        /// Deletes an user by its email
        /// </summary>
        /// <param name="email">The user email</param>
        /// <returns></returns>
        [HttpDelete("{email}")]
        public async Task<IActionResult> Delete(string email)
        {
            var deletedUser = await service.Delete(email);

            return NoContent();
        }
    }
}
