using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic
{
    public class UserAplicationService : IUserAplicationService
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
