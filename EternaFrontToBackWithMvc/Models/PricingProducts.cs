using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class PricingProducts
    {
        public int Id { get; set; }


        public Pricing Pricing { get; set; }
        public int PricingId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
