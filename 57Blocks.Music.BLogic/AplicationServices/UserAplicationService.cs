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
    public class UserAplicationService : IUserAplicationService
    {
        private readonly IUserRepository<User> userRepository;

        public UserAplicationService(IUserRepository<User> _userRepository)
        {
            this.userRepository = _userRepository;
        }

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
