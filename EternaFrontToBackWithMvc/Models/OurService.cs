using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class OurService
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Portfolio Portfolio{ get; set; }
        public int PortfolioId { get; set; }
    }
}
