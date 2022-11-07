using EternaFrontToBackWithMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<HeroCarousel> HeroCarousels { get; set; }
        public DbSet<Feature>Features { get; set; }
        public DbSet<About> Abouts { get; set; }

    }
}
