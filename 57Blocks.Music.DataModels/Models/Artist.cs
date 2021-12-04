using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    [Table("artists")]
    public class Artist : MediaEntity
    {        
        public string Abstract { get; set; }

        public IEnumerable<Album> Albums { get; set; }

        public Artist() { }
    }
}
