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

            Post newPost = new Post(post.Title, post.Url, UserId);

            string userName = _context.Users.Find(UserId).Username;

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            return newPost.ToDto();
        }

        public PostResponseDto UpdatePost(int id, PostRequestDto post)
        {
            //validation

            Post updatedPost = _context.Posts.FirstOrDefault(p => p.Id == id);
            updatedPost.Title = post.Title;
            updatedPost.Url = post.Url;
            updatedPost.TimeStamp = (DateTimeOffset.UtcNow).ToUnixTimeSeconds();

            _context.Posts.Update(updatedPost);
            _context.SaveChanges();

            return updatedPost.ToDto();
        }

        public void DeletePost(int id)
        {
            //validation

            Post deletedPost = _context.Posts.Find(id);

            _context.Posts.Remove(deletedPost);
            _context.SaveChanges();
        }
    }
}
