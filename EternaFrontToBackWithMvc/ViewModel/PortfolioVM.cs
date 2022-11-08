using EternaFrontToBackWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.ViewModel
{
    public class PortfolioVM
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<OurService> OurServices { get; set; }
        public List<Client> Clients { get; set; }
        public List<PortfolioGroup> PortfolioGroups { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }
        




    }
}
