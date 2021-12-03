using System;
using System.Collections.Generic;
using System.Text;

namespace _57Blocks.Music.DataModels.Contracts
{
    public abstract class MediaEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Visible { get; set; }
    }
}
