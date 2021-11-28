using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    public class Song
    {
        public int ArtistId { get; }

        public int AlbumId { get; }

        public string TrackName { get; set; }

        public int UserId { get; set; }

        public TimeSpan TrackDuration { get; set; }
    }
}
