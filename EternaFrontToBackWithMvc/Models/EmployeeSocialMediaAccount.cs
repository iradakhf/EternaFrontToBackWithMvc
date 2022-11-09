using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class EmployeeSocialMediaAccount
    {
        public int Id { get; set; }


        public int SocialMediaAccountId { get; set; }
        public SocialMediaAccount SocialMediaAccount { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
