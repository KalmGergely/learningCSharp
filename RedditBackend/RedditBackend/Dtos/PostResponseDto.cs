namespace RedditBackend.Dtos
{
    public class PostResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Url { get; set; } = null!;

        public int Score { get; set; }

        public long TimeStamp { get; set; }

        public string UserName { get; set; } = null!;
    }
}
