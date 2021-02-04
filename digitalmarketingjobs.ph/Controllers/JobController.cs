using System;
using System.Threading.Tasks;
using digitalmarketingjobs.ph.Data.CustomModels;
using digitalmarketingjobs.ph.Data.Services;
using digitalmarketingjobs.ph.Helper;
using digitalmarketingjobs.ph.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

 

namespace digitalmarketingjobs.ph.Controllers
{
    public class JobController : Controller
    {


        private readonly ILogger<JobController> _logger;

        private IJobService _jobService;
        


        public JobController(ILogger<JobController> logger, IJobService jobService)
        {
            _logger = logger;
            _jobService = jobService;   
        }

        [HttpGet("job/{id}/{title}", Name = "GetJob")]
        public async Task<IActionResult> GetJob(int id, string title)
        {

            var job = await _jobService.GetJobById(id);

           
            if (job== null)
            {
                return this.NotFound();
            }

     
            string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(job.Title);

          
            if (!string.Equals(friendlyTitle, title, StringComparison.Ordinal))
            {
 
                return this.RedirectToRoutePermanent("GetJob", new { id = id, title = friendlyTitle });
            }
 
            return this.View("JobDetail",job);
        }

        [Route("browse-jobs", Name ="BrowseJobs")]
        public async Task<IActionResult> BrowseJobs()
        {
            var jobViewModel = new JobsViewModel();
            var jobFilter = new JobFilter();

            jobFilter.sortBy = 0;
            jobFilter.pageNumber = 1;
            jobFilter.recordsPerPage = 10;
            jobFilter.jobRoleId = 0;
            jobViewModel.Jobs = await _jobService.GetJobs(jobFilter);

            jobViewModel.JobRoles = await _jobService.GetJobRoles();

            jobViewModel.JobTypes = await _jobService.GetJobTypes();


    


            return View(jobViewModel);
        }
    }
}
