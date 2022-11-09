using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFrontToBackWithMvc.Models
{
    public class AuthorSocialMediaAccount
    {
        public int Id { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int SocialMediaAccountId { get; set; }
        public SocialMediaAccount SocialMediaAccount { get; set; }

    }
}
