using Microsoft.EntityFrameworkCore;

namespace FinalProjectGameWebsite.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<DbContext> options) : base(options)
            {
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCharacter>().HasKey(g => new {g.GameId, g.CharacterId});
        }
        public DbSet<Game> Games {get; set;}
    }
}