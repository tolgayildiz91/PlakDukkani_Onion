using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkani_Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Infastructure.EntityMapping
{
    public class UserMapping:BaseEntityMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.UserName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            base.Configure(builder);
        }
   
    }
}
