using System.Collections.Generic;

namespace MusicCollection.Models
{
    public class Music
    {
        public int MusicId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}