using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 1;
            HomeVM homeVM = new HomeVM
            {
               HeroCarousels = _context.HeroCarousels.ToList(),
               Features = _context.Features.ToList()
            };
            return View(homeVM);
        }
    }
}
