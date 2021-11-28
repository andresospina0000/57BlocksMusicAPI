using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Contracts
{
    [JsonObject (NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class MediaEntityViewModel
    {
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int Id { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Name { get; set; }
    }
}
