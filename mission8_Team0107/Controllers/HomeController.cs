using Microsoft.AspNetCore.Mvc;
using mission8_Team0107.Models;
using System.Diagnostics;

namespace mission8_Team0107.Controllers
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

        public IActionResult AddTask()
        {
            return View();
        }
    }
}

// lorin edited this