using RedditBackend.Dtos;
using RedditBackend.Models;

namespace RedditBackend.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext _context;

        public UsersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserResponseDto CreateUser(UserRequestDto user)
        {
            User newUser = new User(user.UserName, user.Password);

            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser.ToDto();
        }

        public List<UserResponseDto> Index()
        {
            //validation
            List<User> users = _context.Users.ToList();
            List<UserResponseDto> responseDtos = new List<UserResponseDto>();

            foreach (var user in users)
            {
                responseDtos.Add(user.ToDto());
            }

            return responseDtos;
        }
    }
}
