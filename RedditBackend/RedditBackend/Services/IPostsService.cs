using RedditBackend.Models;
using RedditBackend.Dtos;

namespace RedditBackend.Services
{
    public interface IPostsService
    {
        public List<PostResponseDto> IndexPosts();

        public PostResponseDto CreatePost(PostRequestDto post, int userId);
    }
}
