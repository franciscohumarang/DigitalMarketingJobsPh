﻿using digitalmarketingjobs.ph.Data.CustomModels;
using digitalmarketingjobs.ph.Data.Models;
using digitalmarketingjobs.ph.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalmarketingjobs.ph.Data.Services
{

    public interface IJobService
    {
        Task<List<Job>> GetJobsByClient(int clientId);
        Task AddJob(Job param);
        Task DeleteJob(int jobId);
        Task MarkJobAsFilled(int jobId);
        Task UpdateJob(Job job);

        Task<List<Job>> GetJobs(JobFilter f);
        Task<List<Job>> GetSpotlightJobs();
        Task<Job> GetJobById(int jobId);
        Task<List<JobType>> GetJobTypes();
        Task<List<JobRole>> GetJobRoles();
    }
    public class JobService:IJobService
    {
        private digitalmarketingjobsContext dbContext = new digitalmarketingjobsContext();

        private IGenericRepository<Job> _jobService;

        private IGenericRepository<JobType> _jobTypeService;

        private IGenericRepository<JobRole> _jobRoleService;

        private string[] arr = new string[3];
       

        public  JobService(IGenericRepository<Job>  jobService, IGenericRepository<JobType> jobTypeService, IGenericRepository<JobRole> jobRoleService)
        {
            _jobService     = jobService;
            _jobRoleService = jobRoleService;
            _jobTypeService = jobTypeService;

            arr[0] = "JobRole";
            arr[1] = "JobType";
            arr[2] = "Client";
        }


        public async Task AddJob(Job  param)
        {
            await _jobService.Insert(param);
         
        }

     
        public  async Task<List<Job>> GetJobsByClient(int clientId)
        {
          /*  return dbContext.Jobs
                .Include(a=>a.Applications)    
                .Where(o => o.ClientId == clientId).ToList();*/

            var arr = new string[1];
            arr[0] = "Applications";

           return await Task.Run(() => _jobService.GetAll(arr).Result
                    .Where(o => o.ClientId == clientId).ToList());
        }

        public async Task DeleteJob(int jobId)
        {
            await _jobService.Delete(jobId);
            
        }

        public async Task<Job> GetJobById(int jobId)
        {


            var job = await _jobService.GetAll(arr);

                var _job = job.Where(j => j.JobId == jobId)
                                         .FirstOrDefault(); 
       

            return _job;
        }

       

        public async Task MarkJobAsFilled(int jobId)
        {
            var job = await _jobService.GetById(jobId);
            job.IsFilled = true;

          await  _jobService.Update(job);
           
        }

        public async Task UpdateJob(Job job)
        {
          await  _jobService.Update(job);
           
        }

        public async Task <List<Job>> GetJobs(JobFilter f)
            
        {
       

            var jobs = new List<Job>();

            if (f.jobRoleId!=0)
            {
                jobs = await Task.Run(() => _jobService.GetAll(arr).Result.Skip((f.pageNumber - 1) * f.recordsPerPage)
                               .Take(f.recordsPerPage).Where(o=>o.JobRoleId==f.jobRoleId).ToList());
            }else
            {
                jobs = await  _jobService.GetAll(arr);

                if (jobs.Count>0)
                    jobs.Skip((f.pageNumber - 1) * f.recordsPerPage)
                               .Take(f.recordsPerPage).ToList();
            }

            if (f.jobTypeId != 0)
            {
                jobs = await Task.Run(() => jobs.Where(o => o.JobTypeId == f.jobTypeId).ToList());
            }
            

            if (f.sortBy==0) //"Newest"
            {
                jobs = await Task.Run(() => jobs.OrderBy(o => o.DatePosted).ToList());
            }
            if (f.sortBy == 1)//"Oldest"
            {
                jobs = await Task.Run(() =>   jobs.OrderByDescending(o => o.DatePosted).ToList());

            }

            if (f.sortBy == 2) //"Expiring Soon"
            {
                jobs = await Task.Run(() => jobs.OrderBy(o => o.DateExpires).ToList());

            }
            if (f.sortBy== 3) //"Salary - Highest First"
            {
                jobs = await Task.Run(() => jobs.OrderBy(o => o.SalaryTo).ToList());

            }
            if (f.sortBy == 4) //"Salary - Lowest First"
            {
                jobs = await Task.Run(() =>  jobs.OrderByDescending(o => o.SalaryTo).ToList());

            }

            return jobs;
        }

        public async Task <List<Job>> GetSpotlightJobs()
        {
       

           var jobs = await _jobService.GetAll(arr);

            if (jobs.Count > 0)
                jobs.Where(o => o.IsSpotlight == true).ToList();

            return jobs;
        }

       public async  Task<List<JobType>> GetJobTypes()
        {
            var jobTypes = await _jobTypeService.GetAll();

            return jobTypes;
        }
        public async Task<List<JobRole>> GetJobRoles()
        {
            var jobRoles = await _jobRoleService.GetAll();

            return jobRoles;
        }
    }
}