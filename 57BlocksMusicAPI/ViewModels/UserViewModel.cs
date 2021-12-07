using _57Blocks.Music.DataModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel.DataAnnotations;

namespace _57BlocksMusicAPI
{
    /// <summary>
    /// The ViewModel desing pattern to separete the business data from the response payload
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UserViewModel
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int userId { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10,ErrorMessage = "The password must have at least 10 characters")]
        //[RegularExpression(@"",ErrorMessage = "Please enter a password with...")]
        public string Password { get; set; }
    }
}
