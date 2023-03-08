using RedditBackend.Models;
using RedditBackend.Dtos;

namespace RedditBackend.Services
{
    public interface IPostsService
    {
        public List<Post> IndexPosts();

        public Post CreatePost(PostRequestDto post);
    }
}
