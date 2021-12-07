using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    /// <summary>
    /// This class implements the reposiroty design pattern, which decouple the business logic  from the data access layer.
    /// It use the context<T> where the generic type <T> refers to the kind of entity/table 
    /// that is going to be affected, i.e., an artist, an album or a song.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MediaRepository<T> : IMediaRepository<T> where T : MediaEntity
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

        public async Task<IEnumerable<T>> GetAllPrivate(int userId)
        {
            var privateEntities = context.DataSet.Where(
                    x => x.UserId.Equals(userId) && x.Visible.Equals(false)
                ).ToList();

            return await Task.FromResult(privateEntities);
        }

        public async Task<IEnumerable<T>> GetAllPublic(int userId)
        {
            var privateEntities = context.DataSet.Where(
                    x => x.UserId.Equals(userId) && x.Visible.Equals(true)
                ).ToList();

            return await Task.FromResult(privateEntities);
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
