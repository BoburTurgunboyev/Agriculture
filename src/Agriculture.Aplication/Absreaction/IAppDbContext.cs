using Agriculture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.Absreaction
{
    public interface IAppDbContext
    {
        public DbSet<Shop> shops { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Product> products { get; set; } 
        public DbSet<ProductNews> productsNews { get; set; }
        public DbSet<ProductService> productsService { get; set; }  
        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
