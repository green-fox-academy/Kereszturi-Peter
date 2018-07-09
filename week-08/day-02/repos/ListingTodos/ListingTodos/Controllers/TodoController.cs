using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Repositories;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private TodoService todoService;

        public TodoController(TodoService todoService)
        {
            this.todoService = todoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("list")]
        public IActionResult List()
        {
            return Content("This is my first todo");
        }
    }
}