using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class AboutVM
    {
        public List<About> Abouts { get; set; }
        public List<Client> Clients { get; set; }
        public List<Count> Counts { get; set; }
        public List<Testimonial> Testimonials { get; set; }



    }
}
