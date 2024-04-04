using BloggingWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BloggingWebApp.Controllers
{
    public class BlogController : Controller
    {
        [BindProperty]
        public Blog Blog { get; set; }

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
        public IActionResult Create()
        {
            Blog blog = new Blog();

            List<Category> categories = dbContext.Categories.ToList();
            ViewBag.Categories = categories;

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if(ModelState.IsValid)
            {
                Blog.Category = dbContext.Categories.First(cate => cate.Id == int.Parse(Blog.CateId));
                dbContext.Blogs.Add(Blog);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var postToDelete = dbContext.Blogs.FirstOrDefault(u => u.Id == id);
            if(postToDelete != null)
            {
                dbContext.Blogs.Remove(postToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
