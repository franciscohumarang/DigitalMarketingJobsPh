using System;
using System.Collections.Generic;
using System.Collections;

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
        public BitArray IsRecommended { get; set; }
    }
}
