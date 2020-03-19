using System.Collections.Generic;

namespace MusicCollection.Models
{
    public class Type
    {
        public Type()
        {
            this.Collections = new HashSet<Collection>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
    }
}