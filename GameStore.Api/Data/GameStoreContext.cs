using Microsoft.EntityFrameworkCore;
using GameStore.Api.Entities;
namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
    : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fighting"},
            new { Id = 2, Name = "Romance"},
            new { Id = 3, Name = "Action"},
            new { Id = 4, Name = "Drama"},
            new { Id = 5, Name = "Animated"}
        );
    }
}
