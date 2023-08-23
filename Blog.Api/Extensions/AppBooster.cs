using Blog.Application.Services.Blog;
using Blog.Infrastructure.Repositories.Blog;

namespace Blog.Api.Extensions
{
    public static class AppBooster
    {
        public static IServiceCollection Boost(this IServiceCollection service)
        {

            service.RegisterRepositories();

            service.RegisterService();

            return service;
        }


        public static IServiceCollection RegisterRepositories(this IServiceCollection service)
        {
            service.AddScoped<IBlogPostRepository, BlogPostRepository>();

            return service;
        }

        public static IServiceCollection RegisterService(this IServiceCollection service)
        {
            service.AddScoped<IBlogService, BlogService>();
            return service;
        }
    }
}
