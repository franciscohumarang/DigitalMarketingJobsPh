using System;
using System.Collections.Generic;
using System.Collections;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Job
    {
        public long JobId { get; set; }
        public int JobTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateExpires { get; set; }
        public bool? IsFilled { get; set; }
        public int ClientId { get; set; }
        public int? SalaryFrom { get; set; }
        public int? SalaryTo { get; set; }
        public string Tags { get; set; }
        public int? JobRoleId { get; set; }
        public BitArray IsSpotlight { get; set; }
        public BitArray FilterCandidate { get; set; }
    }
}
