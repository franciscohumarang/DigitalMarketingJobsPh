using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using digitalmarketingjobs.ph.Models;
using digitalmarketingjobs.ph.Data.Services;
using digitalmarketingjobs.ph.Data.CustomModels;

namespace digitalmarketingjobs.ph.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IJobService _jobService;


        public HomeController(ILogger<HomeController> logger, IJobService jobService)
        {
            _logger = logger;
            _jobService = jobService;
        }

        public async Task<IActionResult> Index()
        {
            var jobFilter = new JobFilter();

            jobFilter.sortBy = 0;
            jobFilter.pageNumber = 1;
            jobFilter.recordsPerPage = 5;
            jobFilter.jobRoleId = 0;

            var recentJobs =await _jobService.GetJobs(jobFilter);

            var spotlightJobs =await  _jobService.GetSpotlightJobs();

            var model = new HomeViewModel();

            model.RecentJobs = recentJobs?.ToList() ;
            model.spotlightJobs = spotlightJobs?.ToList();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ??
                HttpContext.TraceIdentifier });
        }
    }
}