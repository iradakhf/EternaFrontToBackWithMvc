using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Profession { get; set; }
        public string Comment { get; set; }
    }
}
