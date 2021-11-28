using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class ArtistAplicationService : IMediaAplicationService<Artist>
    {
        public Task<Artist> Create(Artist mediaEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
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

        public Task<Artist> Update(Artist mediaEntity)
        {
            throw new NotImplementedException();
        }
    }
}
