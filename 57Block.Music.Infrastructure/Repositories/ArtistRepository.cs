using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicDbLiteContext dbLiteContext;

        public ArtistRepository(MusicDbLiteContext _dbLiteContext)
        {
            this.dbLiteContext = _dbLiteContext;
        }

        public async Task<Artist> CreateEntity(Artist entity)
        {
            await dbLiteContext.artists.AddAsync(entity);
            _ = dbLiteContext.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public async Task<bool> DeleteEntity(string entityId)
        {
            bool isDeleted = false;

            var artist = dbLiteContext.artists.Where(
                x => x.Id.Equals(entityId)).FirstOrDefault();

            dbLiteContext.artists.Remove(artist);
            await dbLiteContext.SaveChangesAsync();

            return await Task.FromResult(!isDeleted);
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
