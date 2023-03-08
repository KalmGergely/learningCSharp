using System.ComponentModel.DataAnnotations;

namespace RedditBackend.Models
{
    public class User
    {
        public int Id { get; set; }

        [MinLength(4)]
        public string Username { get; set; } = null!;

        [MinLength(10)]
        public string Password { get; set; } = null!;

        public int Vote { get; set; }

        public ICollection<Post> Posts { get; set; } = null!;
        public ICollection<Vote> Votes { get; set; } = null!;
    }
}
