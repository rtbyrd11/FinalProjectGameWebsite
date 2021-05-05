using Microsoft.EntityFrameworkCore;

namespace FinalProjectGameWebsite.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext (DbContextOptions<GameDbContext> options)
            : base(options)
            {
            }
            public DbSet<Game> Games {get; set;}
    }
}