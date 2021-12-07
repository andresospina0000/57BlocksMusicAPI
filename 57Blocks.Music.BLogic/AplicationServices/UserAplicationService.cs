using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels;
using _57Block.Music.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _57Block.Music.Infrastructure.Exceptions;
using System.Net;
using _57Block.Music.Infrastructure.Repositories.Contracts;

namespace _57Blocks.Music.BLogic
{
    /// <summary>
    /// The aplication service class for the user entities. Implements the IUserAplicationService interface
    /// </summary>
    public class UserAplicationService : IUserAplicationService
    {
        private readonly IUserRepository<User> userRepository;

        /// <summary>        
        /// The constructor with all the dependencies injection needed
        /// </summary>
        /// <param name="_userRepository"></param>
        public UserAplicationService(IUserRepository<User> _userRepository)
        {
            this.userRepository = _userRepository;
        }

        /// <summary>
        /// Creates an user.
        /// Validates if the sent email already exist, if it exists, the user is not created.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> Create(User user)
        {
            var emailExist = await GetByEmail(user.Email);

            if (emailExist != null)
            {
                throw new MusicApiException(HttpStatusCode.Conflict);
            }

            var createdUser = await userRepository.CreateUser(user);

            return createdUser;
        }

        /// <summary>
        /// Updates an user if it exists on the database.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> Update(User user)
        {
            var emailExist = await GetByEmail(user.Email);

            if (emailExist == null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            user.userId = emailExist.userId;

            var updateUser = await userRepository.UpdateUser(user);

            return updateUser;
        }

        /// <summary>
        /// Deletes an user if it exists on the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> Delete(string email)
        {
            var emailExist = await GetByEmail(email);

            if (emailExist == null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            var deleted = await userRepository.DeleteUser(email);

            return deleted;
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an user from the database by its email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetByEmail(string email)
        {
            var user = await userRepository.GetUserByEmail(email);

            return user;
        }

        public Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
