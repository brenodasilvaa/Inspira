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
    internal class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Comments).WithOne(x => x.Post).HasForeignKey(x => x.PostId);
            builder.HasOne(x => x.TrackSource).WithMany(x => x.Posts).HasForeignKey(x => x.TrackSourceId);
            builder.HasOne(x => x.TrackDest).WithMany().HasForeignKey(x => x.TrackDestId);
        }
    }
}
