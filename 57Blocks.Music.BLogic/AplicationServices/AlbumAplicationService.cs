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
    /// The aplication service class for the albums entities. inherits from the abstract class MediaAplicationService<T> where <T>, in this case, is an Album entity
    /// </summary>
    public class AlbumAplicationService : MediaAplicationService<Album>, IAlbumAplicationService
    {
        private readonly IAlbumRepository repository;
        private readonly IUserAplicationService userService;

        /// <summary>
        /// The constructor with all the dependencies injection needed
        /// </summary>
        /// <param name="_repository"></param>
        /// <param name="_userService"></param>
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
