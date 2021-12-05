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
    public class SongAplicationService : MediaAplicationService<Song>, ISongAplicationService
    {
        private readonly ISongRepository repository;
        private readonly IUserAplicationService userService;

        public SongAplicationService(ISongRepository _repository,
            IUserAplicationService _userService) : base(_repository, _userService)
        {
            this.repository = _repository;
            this.userService = _userService;
        }

        public async Task<IEnumerable<Song>> GetAlbumSongs(string albumId)
        {
            throw new NotImplementedException();
        }
    }
}
