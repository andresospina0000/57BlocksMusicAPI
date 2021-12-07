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
    /// <summary>
    /// The aplication service class for the song entities. inherits from the abstract class MediaAplicationService<T> where <T>, in this case, is an Song entity
    /// </summary>
    public class SongAplicationService : MediaAplicationService<Song>, ISongAplicationService
    {
        private readonly ISongRepository repository;
        private readonly IUserAplicationService userService;

        /// <summary>
        /// The constructor with all the dependencies injection needed
        /// </summary>
        /// <param name="_repository"></param>
        /// <param name="_userService"></param>
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
