using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories.Blog
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<Domain.Entities.BlogPost>> BlogPostsAsync();

        Task<bool> InsertAsync(BlogPost blogPost);
    }
}
