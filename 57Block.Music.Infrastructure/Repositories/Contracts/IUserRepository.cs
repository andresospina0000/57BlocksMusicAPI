using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories.Contracts
{
    public interface IUserRepository<User>
    {
        Task<User> CreateUser(User user);

        Task<User> UpdateUser(User user);

        Task<User> DeleteUser(string entityId);

        Task<User> GetUserById(string entityId);
    }
}
