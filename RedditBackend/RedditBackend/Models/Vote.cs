namespace RedditBackend.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int PostId { get; set; }

        public int Value { get; set; }

        public User User { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}
