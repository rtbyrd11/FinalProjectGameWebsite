using Microsoft.EntityFrameworkCore;

namespace FinalProjectGameWebsite.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext (DbContextOptions<CharacterDbContext> options)
            : base(options)
            {
            }
            public DbSet<Character> Characters {get; set;}
    }
}