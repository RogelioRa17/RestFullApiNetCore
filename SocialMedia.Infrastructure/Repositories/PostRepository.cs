using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Domain.Entities;
using SocialMedia.Domain.Interfaces;
using SocialMedia.Infrastructure.Data;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository: IPostRepository
    {
        private readonly RestFullApiContext _context;

        public PostRepository(RestFullApiContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var publicaciones = await this._context.Posts.ToListAsync();
            return publicaciones;
        }

        public async Task<Post> GetPosts(int id)
        {
            var publicaciones = await this._context.Posts.FirstOrDefaultAsync(post => post.PostId == id);
            return publicaciones;
        }

        public async Task Store(Post post)
        {
            this._context.Posts.Add(post);
            await this._context.SaveChangesAsync();
        }
    }
}
