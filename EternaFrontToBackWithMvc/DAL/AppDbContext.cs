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
        public DbSet<Services> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<OurSkill> OurSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<PortfolioGroup> PortfolioGroups { get; set; }
        public DbSet <Contact> Contacts{ get; set; }


    }
}
