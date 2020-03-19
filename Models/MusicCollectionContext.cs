using Microsoft.EntityFrameworkCore;

namespace MusicCollection.Models
{
    public class MusicCollectionContext : DbContext
    {
        public virtual DbSet<Collection> Collections { get; set; }
        public DbSet<Tyoe> Types { get; set; } 

        public MusicCollectionContext(DbContextOptions options) : base(options) { }
    }
}