using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.Models;
using EternaFrontToBackWithMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 8;
            TeamVM teamVM = new TeamVM
            {
                Employees = _context.Employees.Include(es=>es.EmployeeSocialMediaAccounts).ToList(),
                SocialMediaAccounts = _context.SocialMediaAccounts.Include(es=>es.EmployeeSocialMediaAccounts).ToList()
            };
            return View(teamVM);
        }
    }
}
