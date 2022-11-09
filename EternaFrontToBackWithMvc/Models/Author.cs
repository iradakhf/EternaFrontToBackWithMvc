using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }


        public List<BlogAuthor> BlogAuthors { get; set; }
        public List<AuthorSocialMediaAccount> AuthorSocialMediaAccounts { get; set; }

    }
}
