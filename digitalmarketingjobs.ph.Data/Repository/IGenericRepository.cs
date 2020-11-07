using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace digitalmarketingjobs.ph.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(string[] includes);
        Task<T> GetById(object id);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(object id);
      //  Task Save();
    }
}
