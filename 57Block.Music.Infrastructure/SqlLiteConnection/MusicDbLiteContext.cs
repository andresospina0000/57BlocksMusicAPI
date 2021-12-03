using _57Blocks.Music.DataModels;
using _57Blocks.Music.DataModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.SqlLiteConnection
{
    public class MusicDbLiteContext : DbContext
    {
        private ModelBuilder modelBuilder;
        public DbSet<User> users { get; set; }
        public DbSet<Artist> artists { get; set; }
        public DbSet<Album> albums { get; set; }
        public DbSet<Song> songs { get; set; }

        public MusicDbLiteContext(DbContextOptions<MusicDbLiteContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            this.modelBuilder = _modelBuilder;
            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(x => x.userId);
                user.Property(x => x.userId)
                .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Artist>(user =>
            {
                user.HasKey(x => x.Id);
                user.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
