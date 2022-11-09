using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

        public List<CategoryPost> CategoryPosts { get; set; }


    }
}
