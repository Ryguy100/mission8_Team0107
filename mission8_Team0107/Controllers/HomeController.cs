using Microsoft.AspNetCore.Mvc;
using mission8_Team0107.Models;
using System.Diagnostics;

namespace mission8_Team0107.Controllers
{
    public class HomeController : Controller
    {
        private iTaskRepository _repo;

        public HomeController(iTaskRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

// lorin edited this