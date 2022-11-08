using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 4;
            List<Contact> contacts = _context.Contacts.ToList();
            return View(contacts);
        }
    }
}
