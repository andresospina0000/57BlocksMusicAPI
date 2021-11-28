using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abstract { get; set; }
        
        public IEnumerable<Album> Albums { get; set; }
    }
}
