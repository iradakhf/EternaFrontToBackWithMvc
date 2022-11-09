using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PricingProducts> PricingProducts { get; set; }


    }
}
