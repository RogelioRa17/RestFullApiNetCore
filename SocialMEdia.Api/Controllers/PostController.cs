using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Domain.DTOs;
using SocialMedia.Domain.Entities;
using SocialMedia.Domain.Interfaces;
using SocialMedia.Infrastructure.Repositories;
using System.Linq;

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
            var postDto = posts.Select(post => new PostDTO{
                PostId = post.PostId,
                UserId = post.UserId,
                Date = post.Date,
                Description = post.Description,
                Image = post.Image
            });
            return Ok(postDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var posts = await this.postRepository.GetPosts(id);
            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> Store(PostDTO postDto)
        {
            var post = new Post(){
                PostId = postDto.PostId,
                UserId = postDto.UserId,
                Date = DateTime.Now,
                Image = postDto.Image,
                Description = postDto.Description
            };
            await this.postRepository.Store(post);
            return Ok(post);
        }
    }
}
