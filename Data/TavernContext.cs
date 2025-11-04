using Microsoft.EntityFrameworkCore;
using Tavern.API.Data.Models;

namespace Tavern.API.Data
{
    public class TavernContext : DbContext
    {
        public TavernContext(DbContextOptions<TavernContext> options) : base(options) { }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
