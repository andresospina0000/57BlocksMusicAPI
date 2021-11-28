using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    public class ArtistViewModel : MediaEntityViewModel
    {
        public string Abstract { get; set; }

        public IEnumerable<AlbumViewModel> Albums { get; set; }
    }
}
