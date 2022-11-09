using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string ComentorName { get; set; }
        public string ComentorSurname { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public bool IsReply { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
