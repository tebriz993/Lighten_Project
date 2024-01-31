using Lighten_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.Lighten_ProjectDbContext context2;

        public HomeController(Data.Lighten_ProjectDbContext context)
        {
            context2 = context;

        }

        public IActionResult Index()
        {

            List<ServiceProses> processes = context2.ServiceProses.ToList();
            return View(processes);
        }
    }


}
