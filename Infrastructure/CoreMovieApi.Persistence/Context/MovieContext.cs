using CoreMovieApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMovieApi.Persistence.Context;
public class MovieContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CoreMovie;User ID=sa;Password=Password1;TrustServerCertificate=True;");
    }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
}