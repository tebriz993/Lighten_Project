using Lighten_Project.Data;
using Lighten_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lighten_Project.Controllers
{
    
    public class BlogController : Controller
    {
        private readonly Data.Lighten_ProjectDbContext _context;
        public BlogController(Data.Lighten_ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blogs> blogs=_context.Blogs.ToList();
            return View(blogs);
        }
    }
}
