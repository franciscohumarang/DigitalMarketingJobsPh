using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Job
    {
        public Job()
        {
            Applications = new HashSet<Application>();
            CandidateJobs = new HashSet<CandidateJobs>();
        }

        public int JobId { get; set; }
        public int JobTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateExpires { get; set; }
        public bool? IsFilled { get; set; }
        public int ClientId { get; set; }
        public int? SalaryFrom { get; set; }
        public int? SalaryTo { get; set; }
        public string Tags { get; set; }
        public int? JobRoleId { get; set; }
        public bool? IsSpotlight { get; set; }
        public bool? FilterCandidate { get; set; }

        public virtual Client Client { get; set; }
        public virtual JobRole JobRole { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<CandidateJobs> CandidateJobs { get; set; }
    }
}
