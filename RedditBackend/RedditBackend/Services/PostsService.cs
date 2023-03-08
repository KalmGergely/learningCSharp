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
        public List<Post> IndexPosts()
        {
            return //List<PostResponseDto>;
        }

        public Post CreatePost(PostRequestDto post, //int userId)
        {
            //validation

            Post newPost = new Post()
            {
                Title = post.Title,
                Url = post.Url,
                Score = 0,
                TimeStamp = (DateTimeOffset.UtcNow).ToUnixTimeSeconds(),
                UserId = //userId
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();
            return //postresponseDto;
        }
    }
}
