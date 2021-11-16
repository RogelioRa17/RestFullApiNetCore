using System;
using System.Collections.Generic;
using System.Linq;
using SocialMedia.Domain.Entities;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post()
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now.Date,
                Image = "http://34.232.229.6:8083/bg-home.7882403fce25b30134e9.png",
                UserId = x
            });
            return posts;
        }
    }
}
