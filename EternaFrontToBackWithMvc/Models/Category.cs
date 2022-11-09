using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<BlogCategory> BlogCategories { get; set; }
        public List<CategoryPost> CategoryPosts { get; set; }

    }
}
