using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class JobAlert
    {
        public int JobAlertId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string AlertName { get; set; }
        public string Keywords { get; set; }
        public int? StatusId { get; set; }
        public int? FrequencyId { get; set; }
    }
}
