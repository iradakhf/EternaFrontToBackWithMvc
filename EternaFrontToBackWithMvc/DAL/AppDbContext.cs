using EternaFrontToBackWithMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EternaFrontToBackWithMvc.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<HeroCarousel> HeroCarousels { get; set; }
        public DbSet<Feature> Features { get; set; }
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
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }
        public DbSet<EmployeeSocialMediaAccount> EmployeeSocialMediaAccounts { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PricingProducts> PricingProducts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<CategoryPost> CategoryPosts { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorSocialMediaAccount> AuthorSocialMediaAccounts { get; set; }
        public DbSet<BlogAuthor> BlogAuthors { get; set; }
        public DbSet<Comment> Comments { get; set; }




    }
}
