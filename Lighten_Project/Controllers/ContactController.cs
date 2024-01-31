using Microsoft.AspNetCore.Mvc;

namespace Lighten_Project.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
