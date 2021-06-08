using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public IEnumerable<SeekerRegistration> SeekerRegistrations { get; set; }
        public IEnumerable<Job> Jobs { get; set; }

    }
}