using _57Block.Music.Infrastructure.Exceptions;
using _57Block.Music.Infrastructure.Repositories;
using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class ArtistAplicationService : MediaAplicationService<Artist>, IArtistAplicationService
    {
        private readonly IArtistRepository repository;
        private readonly IUserAplicationService userService;

        public ArtistAplicationService(IArtistRepository _repository,
            IUserAplicationService _userService) : base(_repository, _userService)
        {
            this.repository = _repository;
            this.userService = _userService;
        }

        public override async Task<Artist> Create(Artist artist)
        {
            var user = userService.GetByEmail(artist.Email).Result;

            if (user is null)
            {
                throw new MusicApiException(HttpStatusCode.NotFound);
            }

            artist.UserId = user.userId;

            await repository.CreateEntity(artist);
            return await Task.FromResult(artist);
        }

    }
}
