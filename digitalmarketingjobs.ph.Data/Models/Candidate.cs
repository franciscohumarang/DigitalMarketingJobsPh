using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            Applications = new HashSet<Application>();
            CandidateJobs = new HashSet<CandidateJobs>();
        }

        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateRegistered { get; set; }
        public int? GcashNo { get; set; }
        public string ResumeContent { get; set; }
        public byte[] Photo { get; set; }
        public string ProfessionalTitle { get; set; }
        public string Educations { get; set; }
        public string Experiences { get; set; }
        public string VideoUrl { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<CandidateJobs> CandidateJobs { get; set; }
    }
}
