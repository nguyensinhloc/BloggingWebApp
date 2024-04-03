using BloggingWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BloggingWebApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext dbContext;
        public BlogController(BlogDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Blog> lstBlogs = dbContext.Blogs.ToList();
            return View(lstBlogs);
        }
    }
}
