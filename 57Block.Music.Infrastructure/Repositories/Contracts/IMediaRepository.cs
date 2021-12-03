using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories.Contracts
{
    public interface IMediaRepository<T> : IRepository<T> where T : MediaEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(string id);

        Task<T> GetByName(string name);

        Task<T> GetAllByUserEmail(string email);

        Task<T> GetAllPublic();
    }
}
