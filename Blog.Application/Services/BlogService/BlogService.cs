using Blog.Application.Dto.BlogPostDto;
using Blog.Infrastructure.Repositories.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.BlogService
{
    public class BlogService : IBlogService
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public async Task<bool> InsertAsync(BlogPostDto newPost)
        {
            Domain.Entities.BlogPost post = new Domain.Entities.BlogPost
            {
                Content = newPost.Content,
                Title = newPost.Title,
            };

            return await _blogPostRepository.InsertAsync(post);   
        }
    }
}
