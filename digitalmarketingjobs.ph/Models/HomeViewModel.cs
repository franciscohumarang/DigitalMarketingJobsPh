using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using digitalmarketingjobs.ph.Data.Models;
namespace digitalmarketingjobs.ph.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            
        }

        public  List<Job> RecentJobs { get; set; }
        public  List<Job> spotlightJobs { get; set; }

    }
}
