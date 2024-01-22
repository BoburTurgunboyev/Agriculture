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
    public class ProductNewsConfigration : IEntityTypeConfiguration<ProductNews>
    {
        public void Configure(EntityTypeBuilder<ProductNews> entity)
        {
            entity.HasKey(pn => pn.Id);

            entity.Property(pn => pn.Image)
                .IsRequired();

            entity.Property(pn => pn.Vitamin)
                .IsRequired();

            entity.Property(pn => pn.VitaminDescription)
                .IsRequired();
        }
    }
}
