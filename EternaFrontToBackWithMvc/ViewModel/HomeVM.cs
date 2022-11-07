using EternaFrontToBackWithMvc.DAL;
using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class HomeVM
    {
       public List<HeroCarousel> HeroCarousels { get; set; }
        public List<Feature> Features { get; set; }
        public List<About> Abouts { get; set; }
        public List<Services> Services { get; set; }
        public List<Client> Clients { get; set; }



    }
}
