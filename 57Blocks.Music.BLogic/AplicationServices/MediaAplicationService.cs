using _57Block.Music.Infrastructure.Exceptions;
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
    /// <summary>
    /// This class implement the Aplication Service desing pattern which allows to implement all the business logic for an specific model/controller/view
    /// and allows the interaction of other business logic services.
    /// This class is the main class which implements a high level of abstraction using the generic type <T>  of type MediaEntity, 
    /// allowing any kind of this entity to implement the basic business logic operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MediaAplicationService<T> : IMediaAplicationService<T> where T : MediaEntity
    {
        private readonly IMediaRepository<T> repository;
        private readonly IUserAplicationService userService;

        public MediaAplicationService(IMediaRepository<T> _repository, IUserAplicationService _userService)
        {
            this.repository = _repository;
            this.userService = _userService;
        }

        public virtual async Task<T> Create(T mediaEntity)
        {
            var user = userService.GetByEmail(mediaEntity.Email).Result;

            if (user is null)
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

        public async Task<IEnumerable<T>> GetAllPrivate(string email)
        {
            var user = userService.GetByEmail(email).Result;

            if (user is null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            var privateEntities = await repository.GetAllPrivate(user.userId);

            return privateEntities;
        }

        public async Task<IEnumerable<T>> GetAllPublic(string email)
        {
            var user = userService.GetByEmail(email).Result;

            if (user is null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            var privateEntities = await repository.GetAllPublic(user.userId);

            return privateEntities;
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
