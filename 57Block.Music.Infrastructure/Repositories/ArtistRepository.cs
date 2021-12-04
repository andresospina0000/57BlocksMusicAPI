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
        private static readonly MusicDbLiteContext<Artist> context;

        public ArtistRepository(MusicDbLiteContext<Artist> _context) : base(context)
        {
            
        }
    }
}
