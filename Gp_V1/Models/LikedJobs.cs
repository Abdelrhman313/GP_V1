using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gp_V1.Models
{
    public class LikedJobs
    {
        public int Id { get; set; }

        public DateTime LikedDate { get; set; }

        public int JobId { get; set; }
        public virtual Job Job { get; set; }

        public int SeekerRegistrationId { get; set; }
        public virtual SeekerRegistration SeekerRegistration { get; set; }
    }
}