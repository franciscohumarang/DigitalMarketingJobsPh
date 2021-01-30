using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using digitalmarketingjobs.ph.Data.Models;
using System.Threading.Tasks;

namespace digitalmarketingjobs.ph.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private digitalmarketingjobsContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new digitalmarketingjobsContext();
            table = _context.Set<T>();
        }
        public GenericRepository(digitalmarketingjobsContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public async  Task<List<T>> GetAll()
        {
            return await table.ToListAsync();
           
        }

        public async Task<List<T>> GetAll(string[] includes)
        {
            var query = table.AsQueryable();


            foreach (var include in includes)
                query = query.Include(include);

            return await query.ToListAsync();
        }

      
        public  async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }
        public async Task Insert(T obj)
        {
           await table.AddAsync(obj);

            await _context.SaveChangesAsync();
        }
        public async Task  Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        public async Task Delete(object id)
        {
            T existing =await table.FindAsync(id);
            table.Remove(existing);


            await _context.SaveChangesAsync();


        }
     
    }
}
