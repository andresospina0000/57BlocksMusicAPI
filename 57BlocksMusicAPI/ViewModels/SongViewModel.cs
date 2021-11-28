﻿using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    public class SongViewModel : MediaEntityViewModel
    {
        public int ArtistId { get; }

        public int AlbumId { get; }

        public int UserId { get; set; }

        public TimeSpan TrackDuration { get; set; }
    }
}