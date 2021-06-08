using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string PostImage { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public DateTime PublishDate { get; set; }
    }
}