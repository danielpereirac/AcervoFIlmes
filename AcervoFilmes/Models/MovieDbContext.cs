using System.Data.Entity;
namespace AcervoFilmes.Models
{
    public class MovieDbContext: DbContext
    {
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Actor> Actors { get; set; }
    }
}
