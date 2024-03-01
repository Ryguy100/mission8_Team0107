using Microsoft.AspNetCore.Mvc;
using mission8_Team0107.Models;
using SQLitePCL;
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
            var tasks = sqlite3_context.Tasks.ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View(new TaskEntity());
        }

        [HttpPost]

        public IActionResult AddTask(TaskEntity m)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(m);
                return RedirectToAction("Index");
            }
            return View(m);
        }

        public IActionResult AddTask()
        {
            return View();
        }
    }
}