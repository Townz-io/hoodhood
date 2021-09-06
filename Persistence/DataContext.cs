using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Household> Households { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Utility> Utilities { get; set; }
        public DbSet<Lease> Leases { get; set; }

    }
}