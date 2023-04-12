using PlakDukkani_Onion.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace PlakDukkani_Onion.Infastructure.EntityMapping
{
    public class AlbumMapping:BaseEntityMapping<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> builder)
        {

            builder.Property(p => p.AlbumAdi).HasMaxLength(150);
            builder.Property(p => p.Sanatci).HasMaxLength(150);

            base.Configure(builder);
        }

    }
}
