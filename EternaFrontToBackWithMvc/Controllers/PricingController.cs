using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 6;
            PricingVM pricingVM = new PricingVM
            {
                Pricings = _context.Pricings.Include(pp => pp.PricingProducts).ToList(),
                Products = _context.Products.Include(pp=>pp.PricingProducts).ToList()
            };
            return View(pricingVM);
        }
    }
}
