using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public class SongRepository : IMediaRepository<Artist>
    {
        public Task<Artist> CreateEntity(Artist entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntity(string entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Artist>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetAllByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetEntityById(string entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> UpdateEntity(Artist entity)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetAllPublic()
        {
            throw new NotImplementedException();
        }
    }
}
