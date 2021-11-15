using System;
using System.Collections.Generic;
using System.Linq;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastracture.Repositories
{
    class PostRepository
    {
        public IEnumerable<Post> GetPost()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post{);
        }
    }
}
