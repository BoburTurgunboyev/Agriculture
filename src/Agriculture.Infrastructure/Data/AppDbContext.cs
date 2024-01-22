using Agriculture.Aplication.Absreaction;
using Agriculture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Infrastructure.Data
{
    public class AppDbContext:DbContext,IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            Database.Migrate();
        }

        public DbSet<Shop> shops { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductNews> productsNews { get; set; }
        public DbSet<ProductService> productsService { get; set; }
        public DbSet<User> users { get ; set; }

        async ValueTask<int> IAppDbContext.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken); 
        }
    }
}
