using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public List<Portfolio> Portfolios { get; set; }

    }
}
