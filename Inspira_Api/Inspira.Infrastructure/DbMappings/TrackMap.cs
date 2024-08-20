using Inspira.Domain.Entities;
using Inspira_Music.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Infrastructure.DbMappings
{
    public class TrackMap : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Artists).WithMany(x => x.Tracks);
        }
    }
}
