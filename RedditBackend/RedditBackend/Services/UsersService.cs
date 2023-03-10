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

        public User CreateUser(UserRequestDto user)
        {
            //validation

            User newUser = new User()
            {
                Username = user.UserName,
                Password = user.Password,
                Vote = 0
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public List<User> Index()
        {
            //validation
            return _context.Users.ToList();
        }
    }
}
