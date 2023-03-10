using RedditBackend.Dtos;
using RedditBackend.Models;

namespace RedditBackend.Services
{
    public interface IUsersService
    {
        public User CreateUser(UserRequestDto user);
        public List<User> Index();
    }
}
