using Blog.Application.Dto.BlogPostDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services.BlogService
{
    public interface IBlogService
    {
        Task<bool> InsertAsync(BlogPostDto newPost);
    }
}
