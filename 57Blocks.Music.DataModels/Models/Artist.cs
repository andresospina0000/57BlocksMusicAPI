using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    /// <summary>
    /// The artist data model. Refers to the "artists" table in the database
    /// </summary>
    [Table("artists")]
    public class Artist : MediaEntity
    {        
        public string Abstract { get; set; }

        public IEnumerable<Album> Albums { get; set; }

        public Artist() { }
    }
}
