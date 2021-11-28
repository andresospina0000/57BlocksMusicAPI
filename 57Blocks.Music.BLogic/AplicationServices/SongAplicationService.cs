using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class SongAplicationService : ISongAplicationService
    {
        public Task<Song> Create(Song mediaEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Song>> GetAlbumSongs(string albumId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Song>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Song> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Song> Update(Song mediaEntity)
        {
            throw new NotImplementedException();
        }
    }
}
