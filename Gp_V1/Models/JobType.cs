using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class JobType
    {
        public int Id { get; set; }
        public string JobTypeName { get; set; }
        public IEnumerable<Job> Jobs { get; set; }

    }
}