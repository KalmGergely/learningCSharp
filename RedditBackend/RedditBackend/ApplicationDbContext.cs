using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;

namespace RedditBackend
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> posts { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
