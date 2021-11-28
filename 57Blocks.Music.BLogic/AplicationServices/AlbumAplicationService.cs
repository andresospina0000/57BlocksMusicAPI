using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class AlbumAplicationService : IMediaAplicationService<Album>
    {
        public Task<Album> Create(Album mediaEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Album> Update(Album mediaEntity)
        {
            throw new NotImplementedException();
        }
    }
}
