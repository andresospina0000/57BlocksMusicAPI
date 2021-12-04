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
    public class ArtistRepository : MediaRepository<Artist>, IArtistRepository
    {
        private readonly MusicDbLiteContext<Artist> context;
        //private readonly MusicDbLiteContext context;

        //public ArtistRepository(MusicDbLiteContext _context) : base(_context)
        public ArtistRepository(MusicDbLiteContext<Artist> _context) : base(_context)
        {
            this.context = _context;
        }

        /*public override async Task<Artist> CreateEntity(Artist entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return await Task.FromResult(entity);
        }*/
    }
}
