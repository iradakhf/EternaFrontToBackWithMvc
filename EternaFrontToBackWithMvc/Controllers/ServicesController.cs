using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 7;
            ServicesVM servicesVM = new ServicesVM
            {
               OurSkills = _context.OurSkills.ToList(),
               Skills = _context.Skills.ToList(),
               Services = _context.Services.ToList()
            };
            return View(servicesVM);
        }
    }
}
