using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Resume
    {
        public Resume()
        {
            Application = new HashSet<Application>();
        }

        public int ResumeId { get; set; }
        public string Title { get; set; }
        public string SkillsSummary { get; set; }
        public string SkillsTags { get; set; }
        public byte[] ResumeUpload { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }
}
