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
    public class ShopConfigration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> entity)
        {

            entity.HasKey(s => s.Id);

            entity.Property(s => s.Email)
                .IsRequired();

            entity.Property(s => s.Phone)
                .IsRequired();

            entity.Property(s => s.Address)
                .IsRequired();
        }
    }
}
