using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BloggingWebApp.Models;

namespace BloggingWebApp.Models
{
    public class BlogDbContext : IdentityDbContext<AppUser>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<BloggingWebApp.Models.User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Assuming you have a class that should be keyless
            modelBuilder.Entity<User>().HasNoKey();
        }
    }
}
