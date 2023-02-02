using Microsoft.EntityFrameworkCore;
using SnowSportsGear.Entities;

namespace SnowSportsGear.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
