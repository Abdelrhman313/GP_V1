using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        public string NationalityName { get; set; }
        public IEnumerable<SeekerRegistration> SeekerRegistrations { get; set; }
    }
}