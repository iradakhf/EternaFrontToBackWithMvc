using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }

        public List<EmployeeSocialMediaAccount> EmployeeSocialMediaAccounts { get; set; }



    }
}
