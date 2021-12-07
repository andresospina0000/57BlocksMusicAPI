using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _57Blocks.Music.DataModels.Contracts
{
    /// <summary>
    /// This abstract class defines the base structure of an Artist, Album or Song entity
    /// </summary>
    public abstract class MediaEntity
    {
        /// <summary>
        /// The primary key of the entity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// The name of an album, artis or song
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines either if the entity can be readed by the user that created the entity
        /// or can be accessed by any registered user
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// The user Id that created the artis, album or song
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The email of the user. No saved on the database.
        /// </summary>
        [NotMapped]
        public string Email { get; set; }
    }
}
