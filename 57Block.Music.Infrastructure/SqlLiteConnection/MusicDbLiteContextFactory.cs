using _57Blocks.Music.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.SqlLiteConnection
{
    public class MusicDbLiteContextFactory
    {
        private readonly string ConnectionString;

        public MusicDbLiteContextFactory(string _connectionString)
        {
            ConnectionString = _connectionString;
        }

        /*public MusicDbLiteContext createDbContext()
        {
            DbContextOptionsBuilder<MusicDbLiteContext> dbContextOptions =
                new DbContextOptionsBuilder<MusicDbLiteContext>();
        }*/
    }
}
