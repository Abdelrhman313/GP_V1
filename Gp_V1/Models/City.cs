﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public IEnumerable<RegisterUser> RegisterUsers { get; set; }
        public IEnumerable<SeekerRegistration> SeekerRegistrations { get; set; }
        public IEnumerable<Job> Jobs { get; set; }

    }
}