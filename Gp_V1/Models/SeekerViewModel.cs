using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class SeekerViewModel
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<ApplyedJob> ApplyedJobs { get; set; }
        public IEnumerable<LikedJobs> LikedJobs { get; set; }
        public IEnumerable<LikedCompany> LikedCompanies { get; set; }
    }
}