using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class EducationLevel
    {
        public int Id { get; set; }
        public string EducationLevelName { get; set; }
       
        public IEnumerable<Job> Jobs { get; set; }
    }
}