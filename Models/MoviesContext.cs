using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //constructor
        {

        }
        //helooooooo
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}


