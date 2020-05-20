using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Model
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}