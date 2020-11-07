using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class CandidateJobs
    {
        public int CandidateJobsId { get; set; }
        public int? JobId { get; set; }
        public int? CandidateId { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public bool? IsActive { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Job Job { get; set; }
    }
}
