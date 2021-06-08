using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class ProviderViewModel
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<SeekerRegistration> SeekerRegistrations { get; set; }
    }
}