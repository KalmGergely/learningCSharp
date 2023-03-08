using System.ComponentModel.DataAnnotations;

namespace RedditBackend.Models
{
    public class Post
    {
        public int Id { get; set; }

        [MinLength(5)]
        public string Title { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}
