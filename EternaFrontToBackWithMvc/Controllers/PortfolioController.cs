using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 5;

            return View();
        }
    }
}
