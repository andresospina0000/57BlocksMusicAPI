using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.SqlLiteConnection
{
    public class MusicDbLiteConnection : DbContext
    {
        public MusicDbLiteConnection(DbContextOptions<MusicDbLiteConnection> options) : base(options)
        {

        }
    }
}
