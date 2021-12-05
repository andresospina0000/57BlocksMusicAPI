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
    public class AlbumAplicationService : MediaAplicationService<Album>, IAlbumAplicationService
    {
        private readonly IAlbumRepository repository;
        private readonly IUserAplicationService userService;

        public AlbumAplicationService(IAlbumRepository _repository,
            IUserAplicationService _userService) : base(_repository, _userService)
        {
            this.repository = _repository;
            this.userService = _userService;
        }

        public async Task<IEnumerable<Album>> GetAlbumsByArtist(Artist artist)
        {
            throw new NotImplementedException();
        }
    }
}
