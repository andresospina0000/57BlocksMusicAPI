using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public class AlbumRepository : MediaRepository<Album>, IAlbumRepository
    {
        private readonly MusicDbLiteContext<Album> context;

        public AlbumRepository(MusicDbLiteContext<Album> _context) : base(_context)
        {
            this.context = _context;
        }
    }
}
