using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string JobTitleName { get; set; }
        public IEnumerable<RegisterUser> RegisterUsers { get; set; }
    }
}