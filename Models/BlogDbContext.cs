using Microsoft.EntityFrameworkCore;

namespace BloggingWebApp.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
