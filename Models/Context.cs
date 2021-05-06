using Microsoft.EntityFrameworkCore;

namespace FinalProjectGameWebsite.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options)
            {
            }
        public DbSet<Game> Games {get; set;}
        public DbSet<Character> Characters {get; set;}
    }
}