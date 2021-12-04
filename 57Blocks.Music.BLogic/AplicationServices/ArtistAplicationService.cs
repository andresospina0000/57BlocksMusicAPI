using _57Block.Music.Infrastructure.Repositories;
using _57Block.Music.Infrastructure.Repositories.Contracts;
using _57Block.Music.Infrastructure.SqlLiteConnection;
using _57Blocks.Music.BLogic.Contracts;
using _57Blocks.Music.DataModels;
using _57Blocks.Music.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.AplicationServices
{
    public class ArtistAplicationService : MediaAplicationService<Artist>, IArtistAplicationService
    {

        private readonly IArtistRepository repository;
        private readonly IUserAplicationService userService;
        private readonly MusicDbLiteContext<Artist> context;

        public ArtistAplicationService(IArtistRepository _repository,
            IUserAplicationService _userService,
            MusicDbLiteContext<Artist> _context) : base(_repository, _userService, _context)
        {
            this.repository = _repository;
            this.userService = _userService;
            this.context = _context;
        }
    }
}
