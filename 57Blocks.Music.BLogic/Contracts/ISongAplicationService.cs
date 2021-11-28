using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.Contracts
{
    interface ISongAplicationService : IMediaAplicationService<Song>
    {
        Task<IEnumerable<Song>> GetAlbumSongs(string albumId);
    }
}
