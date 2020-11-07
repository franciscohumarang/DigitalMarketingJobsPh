using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public int? ClientId { get; set; }
        public int? CandidateId { get; set; }
        public DateTime? DateApplied { get; set; }
        public int? ResumeId { get; set; }
        public int? StatusId { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? JobId { get; set; }
        public string CoverLetter { get; set; }
        public bool? IsRecommended { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual Job Job { get; set; }
        public virtual Resume Resume { get; set; }
    }
}
