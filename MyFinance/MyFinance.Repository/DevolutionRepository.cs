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
    public class DevolutionRepository : IDevolutionRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<DevolutionEntity> _dataset;

        public DevolutionRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<DevolutionEntity>();
        }
        public Task<DevolutionEntity> Add(DevolutionEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DevolutionEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DevolutionEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DevolutionEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DevolutionEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<DevolutionEntity> Update(DevolutionEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
