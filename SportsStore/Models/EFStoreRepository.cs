using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}

/*/I’ll add additional functionality as I add features to the application, but for the moment, the repository implementation just
maps the Products property defined by the IStoreRepository interface onto the Products property defined by the StoreDbContext
class. The Products property in the context class returns a DbSet<Product> object, which implements the IQueryable<T> interface
and makes it easy to implement the repository interface when using Entity Framework Core./*/