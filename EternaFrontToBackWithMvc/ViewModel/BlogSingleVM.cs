using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class BlogSingleVM
    {
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Post> Posts { get; set; }
        public List<Author> Authors { get; set; }
        public List<SocialMediaAccount> SocialMediaAccounts { get; set; }
        public List<Comment > Comments { get; set; }




        public Blog Blog { get; set; }
        public Post Post { get; set; }


    }
}
