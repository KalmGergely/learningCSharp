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
    }
}
