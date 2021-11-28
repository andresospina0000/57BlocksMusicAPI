using _57Blocks.Music.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.SqlLiteConnection
{
    public class MusicDbLiteContext : DbContext
    {
        public MusicDbLiteContext(DbContextOptions<MusicDbLiteContext> options) : base(options)
        {

        }
        
        public DbSet<User> users { get; set; }
    }
}
