using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using digitalmarketingjobs.ph.Data.CustomModels;
using digitalmarketingjobs.ph.Data.Models;
using digitalmarketingjobs.ph.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace digitalmarketingjobs.ph.Data.Services
{

    public interface IApplicationService
    {
        Task AddApplication(Application param);
        Task DeleteApplication(int applicationId);
        Task<Application> UpdateApplication(Application param);
        Task<Application> GetApplicationById(int applicationId);
       Task<List<Application>> GetAllApplications();
        Task<List<Application>> GetApplicationByJob(int jobId);

    }
    public class ApplicationService: IApplicationService
    {

        private digitalmarketingjobsContext dbContext= new digitalmarketingjobsContext ();
        private IGenericRepository<Application> _applicationService;
         
        public ApplicationService(IGenericRepository<Application> applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task AddApplication(Application param)
        {
           await  _applicationService.Insert(param);
           
        }

        public async Task DeleteApplication(int applicationId)
        {
            await  _applicationService.Delete(applicationId);
           
        }

        public async Task<List<Application>> GetApplicationsByClient( int clientId)
        {
            // var applcations = dbContext.Applications.Where(o => o.ClientId == clientId).ToList();
            // Task<LogEntity> task = Task.Run<LogEntity>(async () => await GetLogAsync());

            var applcations = await Task.Run(() => _applicationService.GetAll().Result
                               .Where(w => w.ClientId == clientId).ToList());

            return applcations;
        }

        public async Task<List<Application>> GetApplicationByJob (int jobId)
        {

           /* var applicationsByJob = await dbContext.Applications
                                .Include(a => a.Job)
                                .Include(c => c.Candidate)
                                .Include(r => r.Resume)
                                .Where(a => a.JobId == jobId).ToListAsync();
           */
            /*   var applications = (from a in dbContext.Applications
                                   join c in dbContext.Candidates on a.CandidateId equals c.CandidateId
                                   join j in dbContext.Jobs on a.JobId equals j.JobId
                                   where a.JobId == jobId
                                   select new ApplicationModel
                                   {
                                       JobTitle = j.Title,
                                        CoverLetter = a.CoverLetter,
                                         DateApplied = a.DateApplied,
                                         IsRecommended = a.IsRecommended,
                                          Name = c.Name,
                                           Remarks = a.Remarks,
                                            StatusId = a.StatusId,
                                             ResumeId = a.ResumeId,
                                              DateUpdated = a.DateUpdated


                                   }).ToList();*/

            var arr = new string[3];
                    arr[0] = "Job";
                    arr[1] = "Candidate";
                    arr[2] = "Resume";

            var applications = await Task.Run(() => _applicationService.GetAll(arr).Result.Where(o => o.JobId == jobId).ToList());

            return applications;
        }
        public async Task<Application> UpdateApplication(Application param)
        {
            await  _applicationService.Update(param);
          

            var application =  await GetApplicationById(param.ApplicationId);

            return application;
        }

        public async Task<Application> GetApplicationById(int applicationId)
        {
            var application = await _applicationService.GetById(applicationId);

         return application;
        }

        public async Task<List<Application>> GetAllApplications()
        {
            return await _applicationService.GetAll();
        }

        public async Task UpdateApplicationStatus (int applicationId, int statusId)
        {
            var application = await _applicationService.GetById(applicationId);
            application.StatusId = statusId;

            await  _applicationService.Update(application);
        
        }

        public async Task  AddNoteOnApplication (int applicationId, string Remarks)
        {
            var application = await _applicationService.GetById(applicationId);
            application.Remarks = Remarks;

            await _applicationService.Update(application);
           
        }

      

    }
}
