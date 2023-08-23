using Blog.Application.Dto.BlogPostDto;
using Blog.Application.Services.BlogService;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class BlogPostController : ControllerBase
    { 
        private readonly IBlogService _blogService;

        public BlogPostController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost("post")]
        public async Task<IActionResult> GetAllBlogPosts(BlogPostDto post)
        {
            var result = await _blogService.InsertAsync(post); 
            return result ? Ok() : BadRequest() ;
        }
    }
}
