using Lighten_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Controllers
{
    public class AboutController : Controller
    {
        private readonly Data.Lighten_ProjectDbContext context1;

        public AboutController(Data.Lighten_ProjectDbContext context)
        {
            context1 = context;
            
        }
       
        public IActionResult Index()
        {

            List<WhyChooseUs> us = context1.WhyChooseUs.ToList();
            return View(us);
        }


       


    }
}    
  



   
