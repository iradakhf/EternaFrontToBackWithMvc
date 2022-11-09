using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }
        public string ArticleImage { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<BlogCategory> BlogCategories { get; set; }

        public List<BlogTag> BlogTags { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
