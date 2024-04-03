using Microsoft.AspNetCore.Mvc;

namespace BloggingWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
