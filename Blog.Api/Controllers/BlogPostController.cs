using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class BlogPostController : ControllerBase
    { 

        [HttpGet("blog-post")]
        public async Task<IActionResult> GetAllBlogPosts()
        {
            return Ok();
        }
    }
}
