using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _57Blocks.Music.DataModels
{
    [Table("users")]
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
