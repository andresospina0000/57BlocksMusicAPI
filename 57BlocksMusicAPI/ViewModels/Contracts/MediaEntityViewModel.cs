using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Contracts
{
    /// <summary>
    /// This abstract class defines the base structure of an Artist, Album or Song view model
    /// </summary>
    [JsonObject (NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class MediaEntityViewModel
    {        
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy)
            ,DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Name { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Email { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public bool Visible { get; set; }
    }
}
