﻿using _57Block.Music.Infrastructure.Exceptions;
using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels;
using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public abstract class MediaAplicationService<T> : IMediaAplicationService<T> where T : MediaEntity
    {
        private readonly IMediaRepository<T> repository;
        private readonly IUserAplicationService userService;
        private readonly MusicDbLiteContext<T> context;

        public MediaAplicationService(IMediaRepository<T> _repository, IUserAplicationService _userService,
            MusicDbLiteContext<T> _context)
        {
            this.repository = _repository;
            this.userService = _userService;
            this.context = _context;
        }

        public async Task<T> Create(T mediaEntity)
        {
            var user = userService.GetByEmail(mediaEntity.Email).Result;

            if(user is null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            mediaEntity.UserId = user.userId;

            await repository.CreateEntity(mediaEntity);
            return await Task.FromResult(mediaEntity);
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T mediaEntity)
        {
            throw new NotImplementedException();
        }
    }
}
