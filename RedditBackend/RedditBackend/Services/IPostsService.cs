using RedditBackend.Models;

namespace RedditBackend.Services
{
    public interface IPostsService
    {
        public List<Post> IndexPosts();

        public Post CreatePost(Post post);
    }
}
