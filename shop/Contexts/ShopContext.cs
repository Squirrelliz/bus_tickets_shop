using Microsoft.EntityFrameworkCore;
using shop.Models;
namespace shop.Contexts
{

    public class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Bus> Buses { get; set; } = null!;
        public DbSet<RouteOfBus> RoutesOfBuses { get; set; } = null!;
        public DbSet<Stop> Stops{ get; set; } = null!;
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=shopDb;Username=postgres;Password=liza8908");
        }
    }
}
