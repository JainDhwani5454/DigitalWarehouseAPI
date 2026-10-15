using Microsoft.EntityFrameworkCore;
using DigitalWarehouseAPI.Models;

namespace DigitalWarehouseAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Zone> Zones { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Alert> Alerts { get; set; }
    }
}