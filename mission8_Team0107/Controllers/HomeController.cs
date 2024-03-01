using Microsoft.AspNetCore.Mvc;
using mission8_Team0107.Models;
using SQLitePCL;
using System.Diagnostics;
using System.Linq.Expressions;

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
            var tasks = _repo.Tasks.ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();
            return View(new TaskEntity());
        }

        [HttpPost]

        public IActionResult AddTask(TaskEntity m)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(m);
                
                return View("Index", m);
            }
            else
            {
                ViewBag.Categories = _repo.Categories
                    .OrderBy(x => x.CategoryId)
                    .ToList();
                return View(m);
            }
        }
    }
}