﻿using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Block.Music.Infrastructure.Repositories
{
    public class AlbumRepository : IMediaRepository<Album>
    {
        public Task<Album> CreateEntity(Album entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntity(string entityId)
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

        public Task<Album> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAllByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetEntityById(string entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Album> UpdateEntity(Album entity)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAllPublic()
        {
            throw new NotImplementedException();
        }
    }
}
