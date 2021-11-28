using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels;
using System;
using System.Collections.Generic;
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

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> DeleteUser(string entityId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(string entityId)
        {
            throw new NotImplementedException();
        }
    }
}
