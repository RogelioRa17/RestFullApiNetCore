using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Domain.Interfaces;
using SocialMedia.Infrastructure.Repositories;

namespace SocialMEdia.Api.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository postRepository;
        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await this.postRepository.GetPosts();
            return Ok(posts);
        }
    }
}
