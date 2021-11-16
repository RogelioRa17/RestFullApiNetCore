using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infrastructure.Repositories;

namespace SocialMEdia.Api.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
        }
    }
}
