using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Nincs kanál.");
        }

        [Route("hello")]
        public ContentResult Hello()
        {
            return Content("Helloka yoloka!");
        }
    }

}