using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class PortfolioDetailsVM
    {
        public Portfolio Portfolio { get; set; }

        public PortfolioGroup PortfolioGroup { get; set; }
        public OurService OurService { get; set; }

        public Client Client { get; set; }


    }
}
