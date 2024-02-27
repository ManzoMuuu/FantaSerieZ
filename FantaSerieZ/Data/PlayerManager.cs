using Microsoft.EntityFrameworkCore;

namespace FantaSerieZ.Data
{
    public class PlayerManager : DbContext{
        public PlayerManager(DbContextOptions<PlayerManager> options) : base(options){

        }

        public DbSet<Player>? Players { get; set; }
    }
}