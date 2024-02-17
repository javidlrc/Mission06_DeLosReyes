using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //constructor
        {

        }

        public DbSet<Movies> Movies { get; set; }
    }
}


