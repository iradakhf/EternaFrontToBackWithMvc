using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 8;

            return View();
        }
    }
}
