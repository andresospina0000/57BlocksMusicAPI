using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    [Table("songs")]
    public class Song : MediaEntity
    {
        public int ArtistId { get; }

        public int AlbumId { get; }
                
        public TimeSpan TrackDuration { get; set; }

        public Song() { }
    }
}
