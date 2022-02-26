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
    public class EmployeeRepository : IEmployeeRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<EmployeeEntity> _dataset;

        public EmployeeRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<EmployeeEntity>();
        }
        public Task<EmployeeEntity> Add(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeEntity> Update(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }

        EmployeeEntity IRepositoryBase<EmployeeEntity, SqlContext>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
