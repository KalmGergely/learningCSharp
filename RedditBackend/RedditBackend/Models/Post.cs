using RedditBackend.Dtos;
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
        public List<Vote> Votes { get; set; } = null!;

        public Post(string title, string url, int userId)
        {
            Title = title;
            Url = url;
            Score = 0;
            TimeStamp = (DateTimeOffset.UtcNow).ToUnixTimeSeconds();
            UserId = userId;
        }

        public PostResponseDto ToDto()
        {
            return new PostResponseDto()
            {
                Id = Id,
                Title = Title,
                Url = Url,
                Score = Score,
                TimeStamp = TimeStamp,
                UserName = this.User.Username
            };
        }
    }
}
