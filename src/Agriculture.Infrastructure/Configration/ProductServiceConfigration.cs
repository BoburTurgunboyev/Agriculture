using Agriculture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Infrastructure.Configration
{
    public class ProductServiceConfigration : IEntityTypeConfiguration<ProductService>
    {
        public void Configure(EntityTypeBuilder<ProductService> entity)
        {
            entity.HasKey(ps => ps.Id);

            entity.Property(ps => ps.DairyProducts)
                .IsRequired();

            entity.Property(ps => ps.StoreServices)
                .IsRequired();

            entity.Property(ps => ps.DeliveryServices)
                .IsRequired();

            entity.Property(ps => ps.AgriculturalServices)
                .IsRequired();

            entity.Property(ps => ps.OrganicProducts)
                .IsRequired();

            entity.Property(ps => ps.FreshVegetables)
                .IsRequired();

     
        }
    }
}
