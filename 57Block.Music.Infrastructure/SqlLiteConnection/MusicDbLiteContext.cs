using _57Blocks.Music.DataModels;
using _57Blocks.Music.DataModels.Contracts;
using _57Blocks.Music.DataModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.SqlLiteConnection
{
    /// <summary>
    /// This class implements and configurates the database context to enable the connection to the SqLite database
    /// </summary>
    public class MusicDbLiteContext : DbContext
    {
        private ModelBuilder modelBuilder;
        public DbSet<User> users { get; set; }
        public DbSet<Artist> artists { get; set; }

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

            base.OnModelCreating(modelBuilder);
        }
    }

    /// <summary>
    /// This class implements and configurates the database context to enable the connection to the SqLite database.
    /// This class implements a high level of abstraction which allows the execution of CRUD operations for any MediaEntity (Album, Artist or Song)
    /// </summary>
    /// <typeparam name="T">Refers to the type of an Media Entity like an artist, album or song</typeparam>
    public class MusicDbLiteContext<T> : DbContext where T : MediaEntity
    {
        private ModelBuilder modelBuilder;

        public DbSet<T> DataSet { get; set; }

        public MusicDbLiteContext(DbContextOptions<MusicDbLiteContext<T>> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            this.modelBuilder = _modelBuilder;
            modelBuilder.Entity<T>(mediaEntity =>
            {
                mediaEntity.HasKey(x => x.Id);
                mediaEntity.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
