using _57Blocks.Music.DataModels.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ArtistViewModel : MediaEntityViewModel
    {
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Abstract { get; set; }

        
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy)
            , DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<AlbumViewModel> Albums { get; set; }
    }
}
