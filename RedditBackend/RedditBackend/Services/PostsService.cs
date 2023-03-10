using RedditBackend.Models;
using RedditBackend.Dtos;

namespace RedditBackend.Services
{
    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext _context;

        public PostsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PostResponseDto> IndexPosts()
        {
            IQueryable<PostResponseDto> response = from p in _context.Posts
                           join u in _context.Users on p.UserId equals u.Id
                           select new PostResponseDto
                           {
                               Id = p.Id,
                               Title = p.Title,
                               Url = p.Url,
                               Score = p.Score,
                               TimeStamp = p.TimeStamp,
                               UserName = u.Username
                           };
            return response.ToList();
        }

        public PostResponseDto CreatePost(PostRequestDto post, int UserId)
        {
            //validation

            Post newPost = new Post()
            {
                Title = post.Title,
                Url = post.Url,
                Score = 0,
                TimeStamp = (DateTimeOffset.UtcNow).ToUnixTimeSeconds(),
                User = _context.Users.FirstOrDefault(u => u.Id == UserId)
            };

            string userName = _context.Users.Find(UserId).Username;

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            return new PostResponseDto()
            {
                Id = newPost.Id,
                Title = newPost.Title,
                Url = newPost.Url,
                Score = newPost.Score,
                TimeStamp = newPost.TimeStamp,
                UserName = userName
            };
        }
    }
}
