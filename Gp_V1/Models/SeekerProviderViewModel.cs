using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class SeekerProviderViewModel
    {
        public IEnumerable<SeekerRegistration> SeekerRegistrations { get; set; }
        public IEnumerable<RegisterUser> RegisterUsers { get; set; }
    }
}