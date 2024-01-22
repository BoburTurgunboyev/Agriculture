using Agriculture.Aplication.UseCases.ProductCase.Commands;
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
    public class CartConfigration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> entity)
        {
            entity.HasKey(c => c.Id);

            entity.Property(c => c.Quentity)
                .IsRequired();

            entity.Property(c => c.SumTotal)
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

          

        } 
    
    }
}
