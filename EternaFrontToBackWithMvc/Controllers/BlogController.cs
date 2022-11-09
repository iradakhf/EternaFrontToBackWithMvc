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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = 3;
            BlogVM blogVM = new BlogVM
            {
                Blogs = _context.Blogs.ToList(),
                Tags = _context.Tags.ToList(),
                Categories = _context.Categories.Include(bc => bc.BlogCategories).ToList(),
                Publishers = _context.Publishers.Include(bc => bc.Blogs).ToList(),
                Posts = _context.Posts.ToList()

            };
            return View(blogVM);
        }
        public IActionResult BlogSingle(int? id)
        {
            ViewBag.Active = 10;

            BlogSingleVM blogSingleVM = new BlogSingleVM
            {
                Blog = _context.Blogs.Include(bp => bp.Publisher).Include(bt => bt.BlogTags).FirstOrDefault(b => b.Id == id),
                Tags = _context.Tags.Include(bt => bt.BlogTags).ToList(),
                Blogs = _context.Blogs.Include(bt => bt.BlogTags).ToList(),
                Posts = _context.Posts.Include(cp=>cp.CategoryPosts).ToList(),
                Categories = _context.Categories.Include(bc => bc.BlogCategories).Include(cp=>cp.CategoryPosts).ToList(),
                Authors = _context.Authors.Include(ba=>ba.BlogAuthors).Include(sm=>sm.AuthorSocialMediaAccounts).ToList(),
                SocialMediaAccounts = _context.SocialMediaAccounts.ToList(),
                Comments= _context.Comments.Include(bc=> bc.Blog).ToList()

            };
            
            return View(blogSingleVM);
        }
    }
}
