using Inspira_Music.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Inspira.Domain.Entities
{
    public class InspiraDbContext : DbContext
    {
        public InspiraDbContext(DbContextOptions<InspiraDbContext> options)
        : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties().Where(p => p.ClrType == typeof(string)))
                {
                    property.SetMaxLength(100);
                }
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InspiraDbContext).Assembly);
        }
    }
}
