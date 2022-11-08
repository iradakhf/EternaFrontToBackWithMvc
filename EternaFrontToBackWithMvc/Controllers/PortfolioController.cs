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
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 5;
            PortfolioVM portfolioVM = new PortfolioVM
            {
                Portfolios = _context.Portfolios.Include(pi => pi.PortfolioImages).Include(pg => pg.PortfolioGroup).Include(c => c.Client).ToList(),
                Clients = _context.Clients.ToList(),
                OurServices = _context.OurServices.ToList(),
                PortfolioGroups = _context.PortfolioGroups.Include(p => p.Portfolios).ThenInclude(pi => pi.PortfolioImages).ToList(),
                PortfolioImages = _context.PortfolioImages.ToList()
            };
            return View(portfolioVM);

        }
        public IActionResult PortfolioDetails(int? id)
        {
            ViewBag.Active = 9;

            PortfolioDetailsVM portfolioDetailsVM = new PortfolioDetailsVM
            {
                Portfolio = _context.Portfolios.Include(pi => pi.PortfolioImages).Include(os=>os.OurServices).Include(c=>c.Client).FirstOrDefault(p => p.Id == id),


        };
            return View(portfolioDetailsVM);


        }
    }
}
