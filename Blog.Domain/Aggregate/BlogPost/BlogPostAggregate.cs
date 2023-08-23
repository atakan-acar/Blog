using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Aggregate.BlogPost
{
    public class BlogPostAggregate
    {
        public Entities.BlogPost BlogPost { get; private set; }
        public List<Entities.Comment> Comments { get; private set; }

        public BlogPostAggregate(Entities.BlogPost blogPost)
        {
            BlogPost = blogPost ?? throw new ArgumentNullException(nameof(blogPost));
            Comments = new List<Entities.Comment>();
        }

        public void AddComment(Entities.Comment comment)
        {
            Comments.Add(comment);
        }
    }
}
