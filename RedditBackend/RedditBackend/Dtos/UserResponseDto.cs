namespace RedditBackend.Dtos
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Vote { get; set; }
    }
}
