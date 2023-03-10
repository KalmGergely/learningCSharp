using RedditBackend.Dtos;
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

        public List<Post> Posts { get; set; } = null!;
        public List<Vote> Votes { get; set; } = null!;

        public User() { }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Vote = 0;
        }

        public UserResponseDto ToDto()
        {
            return new UserResponseDto()
            {
                Id = Id,
                UserName = Username,
                Password = Password,
                Vote = Vote
            };
        }
    }
}
