using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class PricingVM
    {
        public List<Pricing> Pricings { get; set; }
        public List<Product> Products { get; set; }

    }
}
