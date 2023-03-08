using RedditBackend.Models;

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
            return _context.posts.ToList();
        }

        public Post CreatePost(Post post)
        {
            if (post.Title.Length < 5)
            {
                //throw new exception
            }

            _context.posts.Add(post);
            _context.SaveChanges();
            return post;
        }
    }
}
