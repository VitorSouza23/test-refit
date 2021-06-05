using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace AppConsole.Domain.Users
{
    public interface IPostApi
    {
        [Get("/users/{userId}/posts")]
        Task<IEnumerable<Post>> GetAsync(int userId);

        [Post("/posts")]
        Task<Post> PostAsync(Post post);

        [Put("/posts/{postId}")]
        Task<Post> PutAsync(int postId, Post post);

        [Delete("/posts/{postId}")]
        Task<Post> DeleteAsync(int postId);
    }
}