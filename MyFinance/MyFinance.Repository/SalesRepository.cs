using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly ISalesRepository _salesRepository;

        SqlContext _context = new SqlContext();
        private DbSet<SalesEntity> _dataset;

        public SalesRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<SalesEntity>();
        }
        public Task<SalesEntity> Add(SalesEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<SalesEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalesEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<SalesEntity> Update(SalesEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
