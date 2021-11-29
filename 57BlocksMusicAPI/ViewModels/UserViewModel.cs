using _57Blocks.Music.DataModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel.DataAnnotations;

namespace _57BlocksMusicAPI
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UserViewModel
    {
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Name { get; set; }

        [StringLength(10, ErrorMessage = "The password must have at least 10 characters")]
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string Password { get; set; }

        public User ToEntity(UserViewModel user)
        {
            var userEntity = new User
            {
                Email = this.Email,
                Name = this.Name,
                Password = this.Password
            };

            return userEntity;
        }
    }
}
