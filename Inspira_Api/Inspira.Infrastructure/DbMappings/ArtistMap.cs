using Inspira.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Infrastructure.DbMappings
{
    internal class ArtistMap : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Tracks).WithMany(x => x.Artists);
            builder.HasMany(x => x.Albums).WithOne(x => x.Artist).HasForeignKey(x => x.ArtistId);

        }
    }
}
