using RedditBackend.Dtos;
using RedditBackend.Models;

namespace RedditBackend.Services
{
    public interface IUsersService
    {
        public UserResponseDto CreateUser(UserRequestDto user);
        public List<UserResponseDto> Index();
    }
}
