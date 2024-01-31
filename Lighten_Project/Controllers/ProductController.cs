using Lighten_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly Data.Lighten_ProjectDbContext context3;
        public ProductController(Data.Lighten_ProjectDbContext context)
        {
            context3 = context;
        }
        public IActionResult Index()
        {
            List<OurProducts> products = context3.OurProducts.ToList();
            return View(products);
            
        }
    }
}
