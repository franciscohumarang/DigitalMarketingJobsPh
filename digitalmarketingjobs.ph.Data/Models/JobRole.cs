using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class JobRole
    {
        public JobRole()
        {
            Job = new HashSet<Job>();
        }

        public int JobRoleId { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Job> Job { get; set; }
    }
}
