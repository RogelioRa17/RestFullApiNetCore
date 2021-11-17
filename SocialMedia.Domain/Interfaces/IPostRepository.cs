using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using SocialMedia.Domain.Entities;

namespace SocialMedia.Domain.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPosts(int id);
        Task Store(Post post);
    }
}
