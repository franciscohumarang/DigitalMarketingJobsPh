using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateRegistered { get; set; }
    }
}
