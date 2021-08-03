using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models 
{
    public class StoreDbContext: DbContext 
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}

/*/The DbContext base class provides access to the Entity Framework Core’s underlying functionality, and the Products property
will provide access to the Product objects in the database. The StoreDbContext class is derived from DbContext and adds the
properties that will be used to read and write the application’s data. There is only one property for now, which will provide access to
Product objects./*/