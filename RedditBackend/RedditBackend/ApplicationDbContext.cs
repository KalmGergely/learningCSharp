using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;

namespace RedditBackend
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Votes { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Post>()
                .HasMany(x => x.Votes)
                .WithOne(x => x.Post)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vote>()
                .HasOne(x => x.User)
                .WithMany(x => x.Votes)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
