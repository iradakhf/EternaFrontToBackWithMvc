using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class BlogVM
    {
        public List<Blog> Blogs{ get; set; }
        public List<Tag> Tags { get; set; }
        public List<Post> Posts { get; set; }

        public List<Category> Categories { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }

        public List<Publisher> Publishers { get; set; }


    }
}
