using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private readonly MusicDbLiteContext dbLiteContext;
        private const string USER_TABLE = "users";

        public UserRepository(MusicDbLiteContext _dbLiteContext)
        {
            this.dbLiteContext = _dbLiteContext;
        }

        public async Task<User> CreateUser(User user)
        {
            await dbLiteContext.users.AddAsync(user);
            _ = dbLiteContext.SaveChangesAsync();

            return await Task.FromResult(user);
        }

        public Task<User> GetUserByEmail(string email)
        {
            var user = dbLiteContext.users.Where(
                x => x.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();

            return Task.FromResult(user);
        }

        public Task<User> UpdateUser(User user)
        {
            /*var currentUser = dbLiteContext.users.Where(
                x => x.Email.ToLower().Equals(user.Email.ToLower())
                ).FirstOrDefault();*/

            var currentUser = dbLiteContext.users.Where(
                x => x.userId.Equals(user.userId)).FirstOrDefault();

            currentUser.Email = user.Email;
            currentUser.Name = user.Name;
            currentUser.Password = user.Password;
            
            dbLiteContext.SaveChangesAsync();

            return Task.FromResult(user);
        }

        public Task<bool> DeleteUser(string email)
        {
            bool isDeleted = false;

            var user = dbLiteContext.users.Where(
                x => x.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();

            dbLiteContext.users.Remove(user);
            dbLiteContext.SaveChangesAsync();

            return Task.FromResult(!isDeleted);
        }

        public async Task<User> GetUserById(string entityId)
        {
            throw new NotImplementedException();
        }
    }
}
