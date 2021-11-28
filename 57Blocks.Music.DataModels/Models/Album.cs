using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    public class Album
    {
        public int Id { get; set; }

        public int ArtistId { get; set; }

        public string Title { get; set; }

        public IEnumerable<Song> Tracks { get; set; } 
    }
}
