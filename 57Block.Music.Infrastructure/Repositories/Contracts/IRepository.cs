using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T> where T : MediaEntity
    {
        Task<T> CreateEntity(T entity);

        Task<T> UpdateEntity(T entity);

        Task<bool> DeleteEntity(string entityId);

        Task<T> GetEntityById(string entityId);
    }
}
