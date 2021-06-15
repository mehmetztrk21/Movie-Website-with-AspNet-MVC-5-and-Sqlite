using Microsoft.EntityFrameworkCore;
using movie.entity;

namespace movie.data.Concrete
{
    public class database : DbContext
    {
        public DbSet<About> About { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Awards> Awards { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=movieDb");
        }
    }
}