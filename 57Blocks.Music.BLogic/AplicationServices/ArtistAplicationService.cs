using _57Block.Music.Infrastructure.Repositories;
using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class ArtistAplicationService : MediaRepository<Artist>, IArtistAplicationService
    {
        private readonly IArtistRepository repository;

        public ArtistAplicationService(IArtistRepository _repository) : base()
        {
            this.repository = _repository;
        }

        public Task<Artist> Create(Artist mediaEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> Update(Artist mediaEntity)
        {
            throw new NotImplementedException();
        }
    }
}
