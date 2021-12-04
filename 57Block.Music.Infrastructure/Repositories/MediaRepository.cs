using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public abstract class MediaRepository<T>: IMediaRepository<T> where T : MediaEntity 
    {
        private readonly MusicDbLiteContext<T> context;

        public MediaRepository(MusicDbLiteContext<T> _context)
        {
            this.context = _context;
        }

        public virtual async Task<T> CreateEntity(T entity)
        {
            await context.DataSet.AddAsync(entity);
            await context.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public Task<bool> DeleteEntity(string entityId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllPublic()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntityById(string entityId)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
