using System;
using System.Collections.Generic;
using digitalmarketingjobs.ph.Data.Models;

namespace digitalmarketingjobs.ph.Models
{
    public class JobsViewModel
    {
        public List<Job> Jobs { get; set; }

        public List<JobType> JobTypes { get; set; }

        public List<JobRole> JobRoles { get; set; }
    }

}
