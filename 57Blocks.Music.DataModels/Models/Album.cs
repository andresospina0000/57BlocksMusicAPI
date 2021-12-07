using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    /// <summary>
    /// The album data model. Refers to the "albums" table in the database
    /// </summary>
    [Table("albums")]
    public class Album : MediaEntity
    {
        public string Title { get; set; }

        public IEnumerable<Song> Tracks { get; set; }

        public Album() { }
    }
}
