using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly SqlContext _context;
        private DbSet<T> _dataset;
        public RepositoryBase(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            try
            {
            _dataset.Add(entity);
            await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return entity;
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
