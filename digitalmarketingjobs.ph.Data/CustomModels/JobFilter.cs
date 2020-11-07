using digitalmarketingjobs.ph.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace digitalmarketingjobs.ph.Data.CustomModels
{
    public class JobFilter
    {

    public int sortBy { get; set; }
    public int jobRoleId { get; set; }
    public int jobTypeId { get; set; }
     public int pageNumber { get; set; }
        public int  recordsPerPage { get; set; }
    }
}
