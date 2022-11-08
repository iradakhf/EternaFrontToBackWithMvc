using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
            public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 2;
            AboutVM aboutVM = new AboutVM
            {
                Abouts = _context.Abouts.ToList(),
                Clients = _context.Clients.ToList(),
                Counts =_context.Counts.ToList(),
                Testimonials = _context.Testimonials.ToList()

            };
            return View(aboutVM);

        }

    }
}
