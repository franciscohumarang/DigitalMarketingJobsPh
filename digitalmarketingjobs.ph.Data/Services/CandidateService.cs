using digitalmarketingjobs.ph.Data.Models;
using digitalmarketingjobs.ph.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalmarketingjobs.ph.Data.Services
{
    public interface ICandidateService
    {
        Task AddCandidate(Candidate param);
        Task UpdateCandidate(Candidate param);

        Task<Candidate> GetCandidate(int candidateId);

        Task<Candidate> GetCandidateApplications(int candidateId);

        Task<Candidate> Authenticate(string email, string password);
    }

   public class CandidateService
    {
        private digitalmarketingjobsContext dbContext = new digitalmarketingjobsContext();
        private IGenericRepository<Candidate> _candidateService;

        public CandidateService(IGenericRepository<Candidate> candidateService)
        {
            _candidateService = candidateService;
        }

        public async Task AddCandidate(Candidate param)
        {
            await _candidateService.Insert(param);
        }

        public async Task UpdateCandidate(Candidate param)
        {
            await _candidateService.Update(param);
        }

        public async Task DeleteCandidate(int candidateId)
        {
            await _candidateService.Delete(candidateId);
        }

        public async Task<Candidate> GetCandidate(int candidateId)
        {
            return await _candidateService.GetById(candidateId) ;
        }

        public async Task<Candidate> GetCandidateApplications(int candidateId)
        {
            var arr = new string[1];
            arr[0] = "Appplications";

           var candidateWithApplications =  await Task.Run(() => _candidateService.GetAll(arr).Result.Where(o => o.CandidateId == candidateId).FirstOrDefault()) ;
            return candidateWithApplications;
        }

        public async Task<Candidate> Authenticate(string email, string password)
        {
           return  await Task.Run(() => _candidateService.GetAll().Result.Where(a => a.Email == email && a.Password == password).FirstOrDefault());
        }
    }
}
