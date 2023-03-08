using System.ComponentModel.DataAnnotations;

namespace RedditBackend.Models
{
    public class Post
    {
        public int Id { get; set; }

        [MinLength(5)]
        public string Title { get; set; } = null!;

        [MinLength(10)]
        public string Url { get; set; } = null!;

        public int Score { get; set; }

        public long TimeStamp { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = null!;
        public ICollection<Vote> Votes { get; set; } = null!;
    }
}
