using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {


        private MoviesContext _context;

        public HomeController(MoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Collection()
        {

            return View("Collection");
        }

        [HttpPost]
        public IActionResult Collection(Movies response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            
            return View("Confirmation", response);
        }

      
      
    }
}
