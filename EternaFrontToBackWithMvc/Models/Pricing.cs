using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Duration { get; set; }
        public bool IsFeatured { get; set; }


        public List<PricingProducts> PricingProducts { get; set; }
    }
}
