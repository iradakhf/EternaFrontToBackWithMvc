using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class BlogAuthor
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public Author Author { get; set; }



    }
}
