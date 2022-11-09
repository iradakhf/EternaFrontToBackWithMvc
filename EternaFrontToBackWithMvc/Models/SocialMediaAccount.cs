using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class SocialMediaAccount
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }


        public List<EmployeeSocialMediaAccount> EmployeeSocialMediaAccounts { get; set; }
    }
}
