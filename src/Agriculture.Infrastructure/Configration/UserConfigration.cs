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
    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {

            entity.HasKey(u => u.Id);

            entity.Property(u => u.FullName)
                .IsRequired();

            entity.Property(u => u.Image)
                .IsRequired();

            entity.Property(u => u.Job)
                .IsRequired();

        }
    }
}
