using System.Diagnostics;
using izotamizolasyon.Models;
using Microsoft.AspNetCore.Mvc;

namespace izotamizolasyon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hakkimizda()
        {
            return View();
        }
        
        
        public IActionResult iletisim()
        {
            return View();
        }
    }
}
