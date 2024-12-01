using Microsoft.EntityFrameworkCore;
using Socialix.Models;

namespace Socialix.Data
{
    /// <summary>
    /// DbContext
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Config CreatedAt and UpdatedAt
            modelBuilder.Entity<IBaseEntity>()
                .Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<IBaseEntity>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValue(DateTime.UtcNow)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<IBaseEntity>()
                .Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate();
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                                        .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((IBaseEntity)entry.Entity).CreatedAt = DateTime.UtcNow;
                }
                ((IBaseEntity)entry.Entity).UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }


    }
}
