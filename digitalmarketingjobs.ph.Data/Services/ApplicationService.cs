using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using digitalmarketingjobs.ph.Data.Models;
using digitalmarketingjobs.ph.Data.Repository;

namespace digitalmarketingjobs.ph.Data.Services
{

    public interface IApplicationService
    {
        void AddApplication(Application param);
    }
    public class ApplicationService: IApplicationService
    {
        private IGenericRepository<Application> _applicationService;
         
        public ApplicationService(IGenericRepository<Application> applicationService)
        {
            _applicationService = applicationService;
        }

        public void AddApplication(Application param)
        {
            _applicationService.Insert(param);
            _applicationService.Save();
        }

        public void DeleteApplication (int applicationId)
        {
            _applicationService.Delete(applicationId);
            _applicationService.Save();
        }

        public Application UpdateApplication(Application param)
        {
            _applicationService.Update(param);
            _applicationService.Save();

            var application =   GetApplicationById(param.ApplicationId);

            return application;
        }

        public Application GetApplicationById (int applicationId)
        {
            var application = _applicationService.GetById(applicationId);

            return application;
        }

        public List<Application> GetAllApplications()
        {
            return _applicationService.GetAll().ToList();
        }
    }
}
