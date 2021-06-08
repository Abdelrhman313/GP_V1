﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class HomeViewModel
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<RegisterUser> RegisterUsers { get; set; }
    }
}