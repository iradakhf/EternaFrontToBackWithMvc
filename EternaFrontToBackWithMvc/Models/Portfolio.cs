using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ProjectUrl { get; set; }

        public List<PortfolioImage> PortfolioImages { get; set; }
        public List<OurService> OurServices { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Client Client { get; set; }
        public int PortfolioGroupId { get; set; }
        public PortfolioGroup PortfolioGroup { get; set; }



    }
}
