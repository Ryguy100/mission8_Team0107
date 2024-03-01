using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

                ViewBag.Categories = _repo.Categories
                    .OrderBy(x => x.CategoryId)
                    .ToList();
                return View(m);
            }
            else
            {
                ViewBag.Categories = _repo.Categories
                    .OrderBy(x => x.CategoryId)
                    .ToList();
                return View(m);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordToEdit = _repo.Tasks
            .Single(x => x.TaskId == id);

            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddTask", recordToEdit);
        }

        [HttpPost]

        public IActionResult Edit(TaskEntity updatedInfo)
        {
            _repo.UpdateTask(updatedInfo);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Tasks
                .Single(x => x.TaskId == id);

            return View("Index", recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskEntity task)
        {
            _repo.RemoveTask(task);

            return RedirectToAction("Index");
        }
    }
}