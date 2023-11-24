using MaterialExchangeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialExchangeAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Material> Materials { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
